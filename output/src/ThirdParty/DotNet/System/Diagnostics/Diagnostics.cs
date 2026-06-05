// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics
// Classes: 58
// Methods: 430

namespace ThirdParty.DotNet.System.Diagnostics
{
    public class Activity
    {
        // ── Methods ──
        public void get_Source(){} // RVA: 0x7FFAF2F77C50
        public void get_Parent(){} // RVA: 0x7FFAF2F12D00
        public void get_Duration(){} // RVA: 0x7FFAF2DCC010
        public void set_Duration(){} // RVA: 0x7FFAF358F010
        public void get_StartTimeUtc(){} // RVA: 0x7FFAF3246DE0
        public void get_Id(){} // RVA: 0x7FFAF928A1E0
        public void get_ParentId(){} // RVA: 0x7FFAF928A3B0
        public void get_RootId(){} // RVA: 0x7FFAF928A5A0
        public void get_TagObjects(){} // RVA: 0x7FFAF928A680
        public void get_Baggage(){} // RVA: 0x7FFAF928A6F0
        public void SetEndTime(){} // RVA: 0x7FFAF928A790
        public void Stop(){} // RVA: 0x7FFAF928A9B0
        public void get_TraceStateString(){} // RVA: 0x7FFAF928AE70
        public void get_SpanId(){} // RVA: 0x7FFAF928AE90
        public void get_TraceId(){} // RVA: 0x7FFAF928AFD0
        public void get_ActivityTraceFlags(){} // RVA: 0x7FFAF928B050
        public void set_ActivityTraceFlags(){} // RVA: 0x7FFAF928B080
        public void get_ParentSpanId(){} // RVA: 0x7FFAF928B090
        public void IsW3CId(){} // RVA: 0x7FFAF928B320
        public void Dispose(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void SetCustomProperty(){} // RVA: 0x7FFAF928B420
        public void GetCustomProperty(){} // RVA: 0x7FFAF928B6F0
        public void NotifyError(){} // RVA: 0x7FFAF928B8D0
        public void GetRootId(){} // RVA: 0x7FFAF928B910
        public void GetRandomNumber(){} // RVA: 0x7FFAF928B990
        public void TrySetTraceIdFromParent(){} // RVA: 0x7FFAF928B9D0
        public void TrySetTraceFlagsFromParent(){} // RVA: 0x7FFAF928BE00
        public void get_W3CIdFlagsSet(){} // RVA: 0x7FFAF928C050
        public void get_IsStopped(){} // RVA: 0x7FFAF928C060
        public void set_IsStopped(){} // RVA: 0x7FFAF928C070
        public void get_IdFormat(){} // RVA: 0x7FFAF928C0A0
        public void get_Current(){} // RVA: 0x7FFAF928C0B0
        public void SetCurrent(){} // RVA: 0x7FFAF928C130
        public void GetUtcNow(){} // RVA: 0x7FFAF928C2B0
        public void .cctor(){} // RVA: 0x7FFAF928C300
        public void <get_Baggage>g__Iterate|87_0(){} // RVA: 0x7FFAF928C850
    }

    public class ActivityChangedEventArgs
    {
        public object First;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4463510
        public void set_Previous(){} // RVA: 0x7FFAF3ABA2F0
        public void set_Current(){} // RVA: 0x7FFAF4418950
    }

    public class ActivityContext
    {
        // ── Methods ──
        public void get_TraceId(){} // RVA: 0x7FFAF4584690
        public void get_SpanId(){} // RVA: 0x7FFAF44189C0
        public void get_TraceFlags(){} // RVA: 0x7FFAF2DDA5C0
        public void get_TraceState(){} // RVA: 0x7FFAF2D907C0
        public void get_IsRemote(){} // RVA: 0x7FFAF2E7B9D0
        public void Equals(){} // RVA: 0x7FFAF928D860 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAF928D910
        public void GetHashCode(){} // RVA: 0x7FFAF928D950
    }

    public class ActivityEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF928DAD0
    }

    public class ActivityLink
    {
        // ── Methods ──
        public void get_Context(){} // RVA: 0x7FFAF4A4BEA0
        public void get_Tags(){} // RVA: 0x7FFAF4584690
        public void Equals(){} // RVA: 0x7FFAF928DCA0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAF928DD30
        public void GetHashCode(){} // RVA: 0x7FFAF928DDE0
    }

    public class ActivityListener
    {
        // ── Methods ──
        public void get_ActivityStopped(){} // RVA: 0x7FFAF2DA8380
        public void get_ShouldListenTo(){} // RVA: 0x7FFAF2D907C0
        public void Dispose(){} // RVA: 0x7FFAF928E120
    }

    public class ActivitySource : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF928E170
        public void Dispose(){} // RVA: 0x7FFAF928E4D0
        public void AddListener(){} // RVA: 0x7FFAF928E5B0
        public void DetachListener(){} // RVA: 0x7FFAF928E6B0
        public void NotifyActivityStop(){} // RVA: 0x7FFAF928E8A0
        public void .cctor(){} // RVA: 0x7FFAF928EA10
    }

    public class ActivitySpanId
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF3ABA2F0
        public void CreateFromString(){} // RVA: 0x7FFAF928D450
        public void ToHexString(){} // RVA: 0x7FFAF928D5F0
        public void ToString(){} // RVA: 0x7FFAF928D5F0
        public void Equals(){} // RVA: 0x7FFAF928D640 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF928D700
    }

    public class ActivityTraceId
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF3ABA2F0
        public void CreateFromString(){} // RVA: 0x7FFAF928CFD0
        public void ToHexString(){} // RVA: 0x7FFAF928D170
        public void ToString(){} // RVA: 0x7FFAF928D170
        public void Equals(){} // RVA: 0x7FFAF928D1C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF928D280
        public void HexByteFromChars(){} // RVA: 0x7FFAF928D2E0
        public void IsLowerCaseHexAndNotAllZeros(){} // RVA: 0x7FFAF928D3A0
    }

    public class AsyncStreamReader
    {
        // ── Methods ──
        public void Close(){} // RVA: 0x7FFAF2DDAFC0
        public void Dispose(){} // RVA: 0x7FFAF96D8740
        public void CancelOperation(){} // RVA: 0x7FFAF3C49240
    }

    public class BooleanSwitch
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96D3AF0
    }

    public class ConditionalAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
    }

    public class CorrelationManager
    {
        public object SwitchLevelType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_LogicalOperationStack(){} // RVA: 0x7FFAF96D3B90
        public void GetLogicalOperationStack(){} // RVA: 0x7FFAF96D3BA0
    }

    public class DebuggableAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
    }

    public class Debugger
    {
        public object Parent;

        // ── Methods ──
        public void get_IsAttached(){} // RVA: 0x7FFAF88A6150
        public void IsAttached_internal(){} // RVA: 0x7FFAF88A61A0
        public void IsLogging(){} // RVA: 0x7FFAF2D8D320
        public void Log_icall(){} // RVA: 0x7FFAF2D8D310
        public void Log(){} // RVA: 0x7FFAF88A61C0
        public void NotifyOfCrossThreadDependency(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF88A6210
    }

    public class DebuggerBrowsableAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88A5E10
    }

    public class DebuggerDisplayAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88A5F90
        public void set_Name(){} // RVA: 0x7FFAF2D8EE30
        public void set_Type(){} // RVA: 0x7FFAF2DBB0D0
    }

    public class DebuggerHiddenAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DebuggerNonUserCodeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DebuggerStepThroughAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DebuggerTypeProxyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88A5E80
    }

    public class DefaultTraceListener
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF96DE900
        public void GetPrefix(){} // RVA: 0x7FFAF96DEB90
        public void .ctor(){} // RVA: 0x7FFAF96DEC10
        public void get_LogFileName(){} // RVA: 0x7FFAF2F476A0
        public void WriteWindowsDebugString(){} // RVA: 0x7FFAF96DECA0
        public void WriteDebugString(){} // RVA: 0x7FFAF96DECB0
        public void WriteMonoTrace(){} // RVA: 0x7FFAF96DED50
        public void WritePrefix(){} // RVA: 0x7FFAF96DEF70
        public void WriteImpl(){} // RVA: 0x7FFAF96DF000
        public void WriteLogFile(){} // RVA: 0x7FFAF96DF190
        public void Write(){} // RVA: 0x7FFAF96DF3A0
        public void WriteLine(){} // RVA: 0x7FFAF96DF3B0
    }

    public class DiagEnumerator`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10
        public void get_Current(){} // RVA: 0x7FFAF2D33FA0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAF2ABCD60
        public void MoveNext(){} // RVA: 0x7FFAF2ABDBE0
        public void Reset(){} // RVA: 0x7FFAF2AD4A50
        public void Dispose(){} // RVA: 0x7FFAF2AD4A50
        public void .cctor(){} // RVA: 0x7FFAF2AD4A80
    }

    public class DiagNode`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D33FA0
    }

    public class DiagnosticSourceEventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF928EF10
        public void .cctor(){} // RVA: 0x7FFAF928F020
    }

    public class DiagnosticsConfigurationHandler : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9683C70
        public void Create(){} // RVA: 0x7FFAF9683CA0
    }

    public class EnhancedStackFrame
    {
        // ── Methods ──
        public void get_StackFrame(){} // RVA: 0x7FFAF2E55500
        public void get_IsRecursive(){} // RVA: 0x7FFAF8EFC9D0
        public void set_IsRecursive(){} // RVA: 0x7FFAF8EFC9F0
        public void get_MethodInfo(){} // RVA: 0x7FFAF2E2B370
        public void .ctor(){} // RVA: 0x7FFAF8EFCA10
        public void IsEquivalent(){} // RVA: 0x7FFAF8EFCB70
        public void GetFileColumnNumber(){} // RVA: 0x7FFAF370BE80
        public void GetFileLineNumber(){} // RVA: 0x7FFAF304C540
        public void GetFileName(){} // RVA: 0x7FFAF2E08730
        public void GetILOffset(){} // RVA: 0x7FFAF8EFCC00
        public void GetMethod(){} // RVA: 0x7FFAF8EFCC30
        public void GetNativeOffset(){} // RVA: 0x7FFAF8EFCC60
        public void ToString(){} // RVA: 0x7FFAF8EFCC90
    }

    public class EnhancedStackTrace
    {
        // ── Methods ──
        public void Current(){} // RVA: 0x7FFAF8EFCCC0
        public void .ctor(){} // RVA: 0x7FFAF8EFCFD0 | overloaded x2
        public void get_FrameCount(){} // RVA: 0x7FFAF8EFD0E0
        public void GetFrame(){} // RVA: 0x7FFAF8EFD130
        public void GetFrames(){} // RVA: 0x7FFAF8EFDB70 | overloaded x3
        public void ToString(){} // RVA: 0x7FFAF8EFD200
        public void Append(){} // RVA: 0x7FFAF8EFD2D0
        public void GetEnumerator(){} // RVA: 0x7FFAF8EFD4E0
        public void System.Collections.Generic.IEnumerable<System.Diagnostics.EnhancedStackFrame>.GetEnumerator(){} // RVA: 0x7FFAF8EFD520
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF8EFD610
        public void TryGetFullPath(){} // RVA: 0x7FFAF8EFD700
        public void .cctor(){} // RVA: 0x7FFAF8EFD7C0
        public void GetMethodDisplayString(){} // RVA: 0x7FFAF8EFDFF0
        public void IsFSharpAsync(){} // RVA: 0x7FFAF8EFF0C0
        public void TryResolveGeneratedName(){} // RVA: 0x7FFAF8EFF240
        public void TryResolveSourceMethod(){} // RVA: 0x7FFAF8EFFDA0
        public void GetOrdinal(){} // RVA: 0x7FFAF8F003F0
        public void GetMatchHint(){} // RVA: 0x7FFAF8F00740
        public void TryParseGeneratedName(){} // RVA: 0x7FFAF8F00850
        public void IndexOfBalancedParenthesis(){} // RVA: 0x7FFAF8F00B90
        public void GetPrefix(){} // RVA: 0x7FFAF8F00C30
        public void GetParameter(){} // RVA: 0x7FFAF8F00E30
        public void GetValueTupleParameter(){} // RVA: 0x7FFAF8F01350
        public void GetValueTupleParameterName(){} // RVA: 0x7FFAF8F01510
        public void ShowInStackTrace(){} // RVA: 0x7FFAF8F01750
        public void IsStackTraceHidden(){} // RVA: 0x7FFAF8F026A0
        public void TryResolveStateMachineMethod(){} // RVA: 0x7FFAF8F02AE0
        public void <TryResolveStateMachineMethod>g__GetDeclaredMethods|33_0(){} // RVA: 0x7FFAF8F03000
    }

    public class ExceptionExtensions
    {
        // ── Methods ──
        public void SetStackTracesString(){} // RVA: 0x7FFAF8F032D0
        public void Demystify(){} // RVA: 0x7FFAF2D33FA0
        public void ToStringDemystified(){} // RVA: 0x7FFAF8F03350
        public void .cctor(){} // RVA: 0x7FFAF8F033E0
    }

    public class MonitoringDescriptionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96DF400
        public void get_Description(){} // RVA: 0x7FFAF2DA8380
    }

    public class Process
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96D8D50 | overloaded x2
        public void get_Associated(){} // RVA: 0x7FFAF96D8E30
        public void get_HasExited(){} // RVA: 0x7FFAF96D8E40
        public void GetProcessTimes(){} // RVA: 0x7FFAF96D91F0
        public void get_Handle(){} // RVA: 0x7FFAF96D9460
        public void get_Id(){} // RVA: 0x7FFAF96D9530
        public void get_StartInfo(){} // RVA: 0x7FFAF96D9550
        public void set_StartInfo(){} // RVA: 0x7FFAF96D96B0
        public void get_StartTime(){} // RVA: 0x7FFAF96D9760
        public void get_SynchronizingObject(){} // RVA: 0x7FFAF96D97E0
        public void ReleaseProcessHandle(){} // RVA: 0x7FFAF96D99B0
        public void CompletionCallback(){} // RVA: 0x7FFAF96D99E0
        public void Dispose(){} // RVA: 0x7FFAF96D9A00
        public void Close(){} // RVA: 0x7FFAF96D9A50
        public void EnsureState(){} // RVA: 0x7FFAF96D9EE0
        public void EnsureWatchingForExit(){} // RVA: 0x7FFAF96DA160
        public void GetCurrentProcess(){} // RVA: 0x7FFAF96DA340
        public void OnExited(){} // RVA: 0x7FFAF96DA450
        public void GetProcessHandle(){} // RVA: 0x7FFAF96DAC90 | overloaded x2
        public void OpenProcessHandle(){} // RVA: 0x7FFAF96DACA0
        public void Refresh(){} // RVA: 0x7FFAF96DAD50
        public void SetProcessHandle(){} // RVA: 0x7FFAF96DAE10
        public void SetProcessId(){} // RVA: 0x7FFAF96DAE80
        public void Start(){} // RVA: 0x7FFAF96DB330 | overloaded x3
        public void Kill(){} // RVA: 0x7FFAF96DB4F0
        public void StopWatchingForExit(){} // RVA: 0x7FFAF96DB5E0
        public void ToString(){} // RVA: 0x7FFAF96DB830
        public void ProcessName_icall(){} // RVA: 0x7FFAF96DB950
        public void ProcessName_internal(){} // RVA: 0x7FFAF96DB9F0
        public void get_ProcessName(){} // RVA: 0x7FFAF96DBB70
        public void ShellExecuteEx_internal(){} // RVA: 0x7FFAF2D8D320
        public void CreateProcess_internal(){} // RVA: 0x7FFAF2D8D320
        public void StartWithShellExecuteEx(){} // RVA: 0x7FFAF96DBE50
        public void CreatePipe(){} // RVA: 0x7FFAF96DC280
        public void get_IsWindows(){} // RVA: 0x7FFAF8917A40
        public void StartWithCreateProcess(){} // RVA: 0x7FFAF96DC6A0
        public void FillUserInfo(){} // RVA: 0x7FFAF96DD8B0
        public void RaiseOnExited(){} // RVA: 0x7FFAF96DDB90
    }

    public class ProcessInfo
    {
    }

    public class ProcessModuleCollection
    {
    }

    public class ProcessStartInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96DDE20 | overloaded x2
        public void get_ArgumentList(){} // RVA: 0x7FFAF96DDEE0
        public void get_Arguments(){} // RVA: 0x7FFAF96DDFB0
        public void set_Arguments(){} // RVA: 0x7FFAF2DF3E80
        public void get_EnvironmentVariables(){} // RVA: 0x7FFAF96DE010
        public void get_RedirectStandardInput(){} // RVA: 0x7FFAF7974D70
        public void get_RedirectStandardOutput(){} // RVA: 0x7FFAF85A9770
        public void get_RedirectStandardError(){} // RVA: 0x7FFAF9579640
        public void get_StandardErrorEncoding(){} // RVA: 0x7FFAF2F77C50
        public void get_StandardOutputEncoding(){} // RVA: 0x7FFAF2E55590
        public void get_UseShellExecute(){} // RVA: 0x7FFAF2E48C00
        public void get_UserName(){} // RVA: 0x7FFAF96DE660
        public void get_Password(){} // RVA: 0x7FFAF2E55500
        public void get_Domain(){} // RVA: 0x7FFAF96DE6C0
        public void get_LoadUserProfile(){} // RVA: 0x7FFAF2E55570
        public void get_FileName(){} // RVA: 0x7FFAF96DE720
        public void get_WorkingDirectory(){} // RVA: 0x7FFAF96DE780
        public void get_HaveEnvVars(){} // RVA: 0x7FFAF96DE7E0
        public void get_StandardInputEncoding(){} // RVA: 0x7FFAF34CC130
        public void .cctor(){} // RVA: 0x7FFAF96DE7F0
    }

    public class ProcessThreadCollection
    {
    }

    public class ProcessThreadTimes
    {
        // ── Methods ──
        public void get_StartTime(){} // RVA: 0x7FFAF96DDCF0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ProcessWaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96DE8A0
    }

    public class ResolvedMethod
    {
        public object Name;
        public object ResolvedType;
        public object Prefix;
        public object IsDynamicType;

        // ── Methods ──
        public void get_MethodBase(){} // RVA: 0x7FFAF2DA8380
        public void set_MethodBase(){} // RVA: 0x7FFAF2D8EE30
        public void get_DeclaringType(){} // RVA: 0x7FFAF2D907C0
        public void set_DeclaringType(){} // RVA: 0x7FFAF2DF3E80
        public void get_IsAsync(){} // RVA: 0x7FFAF2E7B9D0
        public void set_IsAsync(){} // RVA: 0x7FFAF2E7B9E0
        public void get_IsLambda(){} // RVA: 0x7FFAF316B3A0
        public void set_IsLambda(){} // RVA: 0x7FFAF35D65D0
        public void get_ReturnParameter(){} // RVA: 0x7FFAF2DBB130
        public void set_ReturnParameter(){} // RVA: 0x7FFAF2D8EE90
        public void get_Name(){} // RVA: 0x7FFAF30E74D0
        public void set_Name(){} // RVA: 0x7FFAF2DBB890
        public void get_Ordinal(){} // RVA: 0x7FFAF2F476A0
        public void set_Ordinal(){} // RVA: 0x7FFAF3A001D0
        public void get_GenericArguments(){} // RVA: 0x7FFAF2E0A740
        public void set_GenericArguments(){} // RVA: 0x7FFAF2DB5200
        public void get_ResolvedGenericArguments(){} // RVA: 0x7FFAF2E08730
        public void set_ResolvedGenericArguments(){} // RVA: 0x7FFAF2E08740
        public void get_SubMethodBase(){} // RVA: 0x7FFAF2E2E0E0
        public void set_SubMethodBase(){} // RVA: 0x7FFAF2EE54D0
        public void get_SubMethod(){} // RVA: 0x7FFAF2E55500
        public void set_SubMethod(){} // RVA: 0x7FFAF2E55510
        public void get_Parameters(){} // RVA: 0x7FFAF2E2B370
        public void set_Parameters(){} // RVA: 0x7FFAF2E2B380
        public void get_SubMethodParameters(){} // RVA: 0x7FFAF2E08D50
        public void set_SubMethodParameters(){} // RVA: 0x7FFAF2E08D60
        public void get_RecurseCount(){} // RVA: 0x7FFAF3B95CF0
        public void set_RecurseCount(){} // RVA: 0x7FFAF2F25080
        public void IsSequentialEquivalent(){} // RVA: 0x7FFAF8F03540
        public void ToString(){} // RVA: 0x7FFAF8F03710
        public void Append(){} // RVA: 0x7FFAF8F037B0 | overloaded x2
        public void AppendDeclaringTypeName(){} // RVA: 0x7FFAF8F041F0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ResolvedParameter
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void set_Name(){} // RVA: 0x7FFAF2D8EE30
        public void get_ResolvedType(){} // RVA: 0x7FFAF2D907C0
        public void set_ResolvedType(){} // RVA: 0x7FFAF2DF3E80
        public void get_Prefix(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Prefix(){} // RVA: 0x7FFAF2DBB0D0
        public void get_IsDynamicType(){} // RVA: 0x7FFAF3198A80
        public void set_IsDynamicType(){} // RVA: 0x7FFAF3198B80
        public void .ctor(){} // RVA: 0x7FFAF2DF3E80
        public void ToString(){} // RVA: 0x7FFAF8F042B0
        public void Append(){} // RVA: 0x7FFAF8F04340
        public void AppendTypeName(){} // RVA: 0x7FFAF8F045D0
    }

    public class StackFrame
    {
        // ── Methods ──
        public void get_frame_info(){} // RVA: 0x7FFAF88A62C0
        public void .ctor(){} // RVA: 0x7FFAF88A6380 | overloaded x3
        public void GetFileLineNumber(){} // RVA: 0x7FFAF3A8C9F0
        public void GetFileColumnNumber(){} // RVA: 0x7FFAF3341AF0
        public void GetFileName(){} // RVA: 0x7FFAF30E74D0
        public void GetSecureFileName(){} // RVA: 0x7FFAF88A6440
        public void GetILOffset(){} // RVA: 0x7FFAF2DDA5C0
        public void GetMethod(){} // RVA: 0x7FFAF2DBB130
        public void GetNativeOffset(){} // RVA: 0x7FFAF335BED0
        public void GetMethodAddress(){} // RVA: 0x7FFAF2D907C0
        public void GetMethodIndex(){} // RVA: 0x7FFAF3210030
        public void GetInternalMethodName(){} // RVA: 0x7FFAF2E0A740
        public void ToString(){} // RVA: 0x7FFAF88A64B0
    }

    public class StackTrace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x11
        public void init_frames(){} // RVA: 0x7FFAF88A6730
        public void get_trace(){} // RVA: 0x7FFAF88A69D0
        public void get_FrameCount(){} // RVA: 0x7FFAF6292650
        public void GetFrame(){} // RVA: 0x7FFAF88A6DA0
        public void GetFrames(){} // RVA: 0x7FFAF88A6E10
        public void GetAotId(){} // RVA: 0x7FFAF88A6FD0
        public void AddFrames(){} // RVA: 0x7FFAF88A7080
        public void GetFullNameForStackTrace(){} // RVA: 0x7FFAF88A7630
        public void ConvertAsyncStateMachineMethod(){} // RVA: 0x7FFAF88A7DD0
        public void ToString(){} // RVA: 0x7FFAF88A8220 | overloaded x2
    }

    public class StackTraceHiddenAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class StackTraceHiddenAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class StackTraceHiddenAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Stopwatch
    {
        // ── Methods ──
        public void GetTimestamp(){} // RVA: 0x7FFAF89F0750
        public void StartNew(){} // RVA: 0x7FFAF96DF4A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_Elapsed(){} // RVA: 0x7FFAF96DF540
        public void get_ElapsedMilliseconds(){} // RVA: 0x7FFAF96DF650
        public void get_ElapsedTicks(){} // RVA: 0x7FFAF96DF7A0
        public void get_IsRunning(){} // RVA: 0x7FFAF2E7B9D0
        public void Reset(){} // RVA: 0x7FFAF96DF810
        public void Start(){} // RVA: 0x7FFAF96DF820
        public void Stop(){} // RVA: 0x7FFAF96DF880
        public void Restart(){} // RVA: 0x7FFAF96DF900
        public void .cctor(){} // RVA: 0x7FFAF96DF960
    }

    public class StringBuilderExtentions
    {
        // ── Methods ──
        public void AppendDemystified(){} // RVA: 0x7FFAF8F04640
        public void AppendInnerException(){} // RVA: 0x7FFAF8F04AF0
    }

    public class Switch
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96D3F00 | overloaded x2
        public void _pruneCachedSwitches(){} // RVA: 0x7FFAF96D42F0
        public void .cctor(){} // RVA: 0x7FFAF96D4950
    }

    public class SwitchLevelAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96D4A30
        public void set_SwitchLevelType(){} // RVA: 0x7FFAF96D4A30
    }

    public class SynchronizedList`1
    {
        public object countAll;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
        public void Add(){} // RVA: 0x7FFAF2D33FA0
        public void AddIfNotExist(){} // RVA: 0x7FFAF2D33FA0
        public void Remove(){} // RVA: 0x7FFAF2D33FA0
        public void get_Count(){} // RVA: 0x7FFAF2ABD840
        public void EnumWithAction(){} // RVA: 0x7FFAF2ADDC60
    }

    public class Trace
    {
        public object Callstack;
        public object LogicalOperationStack;
        public object DateTime;

        // ── Methods ──
        public void get_Listeners(){} // RVA: 0x7FFAF96D4B20
        public void get_AutoFlush(){} // RVA: 0x7FFAF96D4B70
        public void get_CorrelationManager(){} // RVA: 0x7FFAF96D4C00
        public void WriteLine(){} // RVA: 0x7FFAF96D4CE0
    }

    public class TraceEventCache
    {
        // ── Methods ──
        public void get_Callstack(){} // RVA: 0x7FFAF96D4D30
        public void get_LogicalOperationStack(){} // RVA: 0x7FFAF96D4E10
        public void get_DateTime(){} // RVA: 0x7FFAF96D4F00
        public void get_ProcessId(){} // RVA: 0x7FFAF96D4FE0
        public void get_ThreadId(){} // RVA: 0x7FFAF96D5030
        public void get_Timestamp(){} // RVA: 0x7FFAF96D51B0
        public void InitProcessInfo(){} // RVA: 0x7FFAF96D5210
        public void GetProcessId(){} // RVA: 0x7FFAF96D4FE0
        public void GetThreadId(){} // RVA: 0x7FFAF89ADCD0
        public void .ctor(){} // RVA: 0x7FFAF96D5390
    }

    public class TraceFilter
    {
        // ── Methods ──
        public void ShouldTrace(){} // RVA: 0x7FFAF96D5400 | overloaded x2
    }

    public class TraceInternal
    {
        public object IsThreadSafe;
        public object IndentLevel;
        public object IndentSize;
        public object Filter;
        public object NeedIndent;

        // ── Methods ──
        public void get_Listeners(){} // RVA: 0x7FFAF96D5450
        public void get_AutoFlush(){} // RVA: 0x7FFAF96D5950
        public void get_UseGlobalLock(){} // RVA: 0x7FFAF96D59B0
        public void get_IndentLevel(){} // RVA: 0x7FFAF96D5A10
        public void get_IndentSize(){} // RVA: 0x7FFAF96D5AB0
        public void InitializeSettings(){} // RVA: 0x7FFAF2D8D310
        public void WriteLine(){} // RVA: 0x7FFAF96D5B10
        public void .cctor(){} // RVA: 0x7FFAF96D6390
    }

    public class TraceListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96D64C0
        public void get_IsThreadSafe(){} // RVA: 0x7FFAF2D8D320
        public void Dispose(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void Flush(){} // RVA: 0x7FFAF2D8D310
        public void set_IndentLevel(){} // RVA: 0x7FFAF96D6590
        public void set_IndentSize(){} // RVA: 0x7FFAF96D65B0
        public void get_Filter(){} // RVA: 0x7FFAF30E74D0
        public void get_NeedIndent(){} // RVA: 0x7FFAF2DA87C0
        public void set_NeedIndent(){} // RVA: 0x7FFAF2F87670
        public void get_TraceOutputOptions(){} // RVA: 0x7FFAF3210030
        public void Write(){} // RVA: 0x7FFAF2AD4B10
        public void WriteIndent(){} // RVA: 0x7FFAF96D6670
        public void WriteLine(){} // RVA: 0x7FFAF2AD4B10
        public void TraceEvent(){} // RVA: 0x7FFAF96D6730
        public void WriteHeader(){} // RVA: 0x7FFAF96D6950
        public void WriteFooter(){} // RVA: 0x7FFAF96D6AF0
        public void IsEnabled(){} // RVA: 0x7FFAF96D7550
    }

    public class TraceListenerCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96D7560
        public void get_Count(){} // RVA: 0x7FFAF88AC050
        public void Add(){} // RVA: 0x7FFAF96D76A0
        public void Clear(){} // RVA: 0x7FFAF96D7880
        public void GetEnumerator(){} // RVA: 0x7FFAF867D010
        public void InitializeListener(){} // RVA: 0x7FFAF96D7920
        public void RemoveAt(){} // RVA: 0x7FFAF96D7AB0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAF96D7C70
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAF96D7CA0
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAF96D7DE0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAF88AC5C0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAF88AC860
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAF96D8080
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAF96D8320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF44EF520
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2E72850
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF96D84E0
    }

    public class TraceSwitch
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96D86A0
    }

    public class TypeNameHelper
    {
        // ── Methods ──
        public void GetTypeDisplayName(){} // RVA: 0x7FFAF8F04BA0
        public void AppendTypeDisplayName(){} // RVA: 0x7FFAF8F04C80
        public void GetTypeNameForGenericType(){} // RVA: 0x7FFAF8F04D10
        public void ProcessType(){} // RVA: 0x7FFAF8F04E30
        public void ProcessArrayType(){} // RVA: 0x7FFAF8F05420
        public void ProcessGenericType(){} // RVA: 0x7FFAF8F05630
        public void .cctor(){} // RVA: 0x7FFAF8F05C60
    }

    public class ValueTupleResolvedParameter
    {
        // ── Methods ──
        public void get_TupleNames(){} // RVA: 0x7FFAF30E74D0
        public void .ctor(){} // RVA: 0x7FFAF8F06AC0
        public void AppendTypeName(){} // RVA: 0x7FFAF8F06B70
        public void AppendValueTupleParameterName(){} // RVA: 0x7FFAF8F06E60
    }

}