// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics
// Classes: 56
// Methods: 428

namespace ThirdParty.DotNet.System.Diagnostics
{
    public class Activity
    {
        // ── Methods ──
        public void get_Source(){} // RVA: 0x4C7C50
        public void get_Parent(){} // RVA: 0x462D00
        public void get_Duration(){} // RVA: 0x31C010
        public void set_Duration(){} // RVA: 0xADF010
        public void get_StartTimeUtc(){} // RVA: 0x796DE0
        public void get_Id(){} // RVA: 0x67DA1E0
        public void get_ParentId(){} // RVA: 0x67DA3B0
        public void get_RootId(){} // RVA: 0x67DA5A0
        public void get_TagObjects(){} // RVA: 0x67DA680
        public void get_Baggage(){} // RVA: 0x67DA6F0
        public void SetEndTime(){} // RVA: 0x67DA790
        public void Stop(){} // RVA: 0x67DA9B0
        public void get_TraceStateString(){} // RVA: 0x67DAE70
        public void get_SpanId(){} // RVA: 0x67DAE90
        public void get_TraceId(){} // RVA: 0x67DAFD0
        public void get_ActivityTraceFlags(){} // RVA: 0x67DB050
        public void set_ActivityTraceFlags(){} // RVA: 0x67DB080
        public void get_ParentSpanId(){} // RVA: 0x67DB090
        public void IsW3CId(){} // RVA: 0x67DB320
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
        public void SetCustomProperty(){} // RVA: 0x67DB420
        public void GetCustomProperty(){} // RVA: 0x67DB6F0
        public void NotifyError(){} // RVA: 0x67DB8D0
        public void GetRootId(){} // RVA: 0x67DB910
        public void GetRandomNumber(){} // RVA: 0x67DB990
        public void TrySetTraceIdFromParent(){} // RVA: 0x67DB9D0
        public void TrySetTraceFlagsFromParent(){} // RVA: 0x67DBE00
        public void get_W3CIdFlagsSet(){} // RVA: 0x67DC050
        public void get_IsStopped(){} // RVA: 0x67DC060
        public void set_IsStopped(){} // RVA: 0x67DC070
        public void get_IdFormat(){} // RVA: 0x67DC0A0
        public void get_Current(){} // RVA: 0x67DC0B0
        public void SetCurrent(){} // RVA: 0x67DC130
        public void GetUtcNow(){} // RVA: 0x67DC2B0
        public void .cctor(){} // RVA: 0x67DC300
        public void <get_Baggage>g__Iterate|87_0(){} // RVA: 0x67DC850
    }

    public class ActivityChangedEventArgs
    {
        public object First;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x19B3510
        public void set_Previous(){} // RVA: 0x100A2F0
        public void set_Current(){} // RVA: 0x1968950
    }

    public class ActivityContext
    {
        // ── Methods ──
        public void get_TraceId(){} // RVA: 0x1AD4690
        public void get_SpanId(){} // RVA: 0x19689C0
        public void get_TraceFlags(){} // RVA: 0x32A5C0
        public void get_TraceState(){} // RVA: 0x2E07C0
        public void get_IsRemote(){} // RVA: 0x3CB9D0
        public void Equals(){} // RVA: 0x67DD860 | overloaded x2
        public void op_Equality(){} // RVA: 0x67DD910
        public void GetHashCode(){} // RVA: 0x67DD950
    }

    public class ActivityEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x67DDAD0
    }

    public class ActivityLink
    {
        // ── Methods ──
        public void get_Context(){} // RVA: 0x1F9BEA0
        public void get_Tags(){} // RVA: 0x1AD4690
        public void Equals(){} // RVA: 0x67DDCA0 | overloaded x2
        public void op_Equality(){} // RVA: 0x67DDD30
        public void GetHashCode(){} // RVA: 0x67DDDE0
    }

    public class ActivityListener
    {
        // ── Methods ──
        public void get_ActivityStopped(){} // RVA: 0x2F8380
        public void get_ShouldListenTo(){} // RVA: 0x2E07C0
        public void Dispose(){} // RVA: 0x67DE120
    }

    public class ActivitySource : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67DE170
        public void Dispose(){} // RVA: 0x67DE4D0
        public void AddListener(){} // RVA: 0x67DE5B0
        public void DetachListener(){} // RVA: 0x67DE6B0
        public void NotifyActivityStop(){} // RVA: 0x67DE8A0
        public void .cctor(){} // RVA: 0x67DEA10
    }

    public class ActivitySpanId
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x100A2F0
        public void CreateFromString(){} // RVA: 0x67DD450
        public void ToHexString(){} // RVA: 0x67DD5F0
        public void ToString(){} // RVA: 0x67DD5F0
        public void Equals(){} // RVA: 0x67DD640 | overloaded x2
        public void GetHashCode(){} // RVA: 0x67DD700
    }

    public class ActivityTraceId
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x100A2F0
        public void CreateFromString(){} // RVA: 0x67DCFD0
        public void ToHexString(){} // RVA: 0x67DD170
        public void ToString(){} // RVA: 0x67DD170
        public void Equals(){} // RVA: 0x67DD1C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x67DD280
        public void HexByteFromChars(){} // RVA: 0x67DD2E0
        public void IsLowerCaseHexAndNotAllZeros(){} // RVA: 0x67DD3A0
    }

    public class AsyncStreamReader
    {
        // ── Methods ──
        public void Close(){} // RVA: 0x32AFC0
        public void Dispose(){} // RVA: 0x6C28740
        public void CancelOperation(){} // RVA: 0x1199240
    }

    public class BooleanSwitch
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C23AF0
    }

    public class ConditionalAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class CorrelationManager
    {
        public object SwitchLevelType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_LogicalOperationStack(){} // RVA: 0x6C23B90
        public void GetLogicalOperationStack(){} // RVA: 0x6C23BA0
    }

    public class DebuggableAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
    }

    public class Debugger
    {
        public object Parent;

        // ── Methods ──
        public void get_IsAttached(){} // RVA: 0x5DF6150
        public void IsAttached_internal(){} // RVA: 0x5DF61A0
        public void IsLogging(){} // RVA: 0x2DD320
        public void Log_icall(){} // RVA: 0x2DD310
        public void Log(){} // RVA: 0x5DF61C0
        public void NotifyOfCrossThreadDependency(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x5DF6210
    }

    public class DebuggerBrowsableAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5DF5E10
    }

    public class DebuggerDisplayAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5DF5F90
        public void set_Name(){} // RVA: 0x2DEE30
        public void set_Type(){} // RVA: 0x30B0D0
    }

    public class DebuggerHiddenAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DebuggerNonUserCodeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DebuggerStepThroughAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DebuggerTypeProxyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5DF5E80
    }

    public class DefaultTraceListener
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6C2E900
        public void GetPrefix(){} // RVA: 0x6C2EB90
        public void .ctor(){} // RVA: 0x6C2EC10
        public void get_LogFileName(){} // RVA: 0x4976A0
        public void WriteWindowsDebugString(){} // RVA: 0x6C2ECA0
        public void WriteDebugString(){} // RVA: 0x6C2ECB0
        public void WriteMonoTrace(){} // RVA: 0x6C2ED50
        public void WritePrefix(){} // RVA: 0x6C2EF70
        public void WriteImpl(){} // RVA: 0x6C2F000
        public void WriteLogFile(){} // RVA: 0x6C2F190
        public void Write(){} // RVA: 0x6C2F3A0
        public void WriteLine(){} // RVA: 0x6C2F3B0
    }

    public class DiagEnumerator`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void get_Current(){} // RVA: 0x283FA0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0xCD60
        public void MoveNext(){} // RVA: 0xDBE0
        public void Reset(){} // RVA: 0x24A50
        public void Dispose(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
    }

    public class DiagNode`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
    }

    public class DiagnosticSourceEventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67DEF10
        public void .cctor(){} // RVA: 0x67DF020
    }

    public class DiagnosticsConfigurationHandler : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD3C70
        public void Create(){} // RVA: 0x6BD3CA0
    }

    public class EnhancedStackFrame
    {
        // ── Methods ──
        public void get_StackFrame(){} // RVA: 0x3A5500
        public void get_IsRecursive(){} // RVA: 0x644C9D0
        public void set_IsRecursive(){} // RVA: 0x644C9F0
        public void get_MethodInfo(){} // RVA: 0x37B370
        public void .ctor(){} // RVA: 0x644CA10
        public void IsEquivalent(){} // RVA: 0x644CB70
        public void GetFileColumnNumber(){} // RVA: 0xC5BE80
        public void GetFileLineNumber(){} // RVA: 0x59C540
        public void GetFileName(){} // RVA: 0x358730
        public void GetILOffset(){} // RVA: 0x644CC00
        public void GetMethod(){} // RVA: 0x644CC30
        public void GetNativeOffset(){} // RVA: 0x644CC60
        public void ToString(){} // RVA: 0x644CC90
    }

    public class EnhancedStackTrace
    {
        // ── Methods ──
        public void Current(){} // RVA: 0x644CCC0
        public void .ctor(){} // RVA: 0x644CFD0 | overloaded x2
        public void get_FrameCount(){} // RVA: 0x644D0E0
        public void GetFrame(){} // RVA: 0x644D130
        public void GetFrames(){} // RVA: 0x644DB70 | overloaded x3
        public void ToString(){} // RVA: 0x644D200
        public void Append(){} // RVA: 0x644D2D0
        public void GetEnumerator(){} // RVA: 0x644D4E0
        public void System.Collections.Generic.IEnumerable<System.Diagnostics.EnhancedStackFrame>.GetEnumerator(){} // RVA: 0x644D520
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x644D610
        public void TryGetFullPath(){} // RVA: 0x644D700
        public void .cctor(){} // RVA: 0x644D7C0
        public void GetMethodDisplayString(){} // RVA: 0x644DFF0
        public void IsFSharpAsync(){} // RVA: 0x644F0C0
        public void TryResolveGeneratedName(){} // RVA: 0x644F240
        public void TryResolveSourceMethod(){} // RVA: 0x644FDA0
        public void GetOrdinal(){} // RVA: 0x64503F0
        public void GetMatchHint(){} // RVA: 0x6450740
        public void TryParseGeneratedName(){} // RVA: 0x6450850
        public void IndexOfBalancedParenthesis(){} // RVA: 0x6450B90
        public void GetPrefix(){} // RVA: 0x6450C30
        public void GetParameter(){} // RVA: 0x6450E30
        public void GetValueTupleParameter(){} // RVA: 0x6451350
        public void GetValueTupleParameterName(){} // RVA: 0x6451510
        public void ShowInStackTrace(){} // RVA: 0x6451750
        public void IsStackTraceHidden(){} // RVA: 0x64526A0
        public void TryResolveStateMachineMethod(){} // RVA: 0x6452AE0
        public void <TryResolveStateMachineMethod>g__GetDeclaredMethods|33_0(){} // RVA: 0x6453000
    }

    public class ExceptionExtensions
    {
        // ── Methods ──
        public void SetStackTracesString(){} // RVA: 0x64532D0
        public void Demystify(){} // RVA: 0x283FA0
        public void ToStringDemystified(){} // RVA: 0x6453350
        public void .cctor(){} // RVA: 0x64533E0
    }

    public class MonitoringDescriptionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C2F400
        public void get_Description(){} // RVA: 0x2F8380
    }

    public class Process
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C28D50 | overloaded x2
        public void get_Associated(){} // RVA: 0x6C28E30
        public void get_HasExited(){} // RVA: 0x6C28E40
        public void GetProcessTimes(){} // RVA: 0x6C291F0
        public void get_Handle(){} // RVA: 0x6C29460
        public void get_Id(){} // RVA: 0x6C29530
        public void get_StartInfo(){} // RVA: 0x6C29550
        public void set_StartInfo(){} // RVA: 0x6C296B0
        public void get_StartTime(){} // RVA: 0x6C29760
        public void get_SynchronizingObject(){} // RVA: 0x6C297E0
        public void ReleaseProcessHandle(){} // RVA: 0x6C299B0
        public void CompletionCallback(){} // RVA: 0x6C299E0
        public void Dispose(){} // RVA: 0x6C29A00
        public void Close(){} // RVA: 0x6C29A50
        public void EnsureState(){} // RVA: 0x6C29EE0
        public void EnsureWatchingForExit(){} // RVA: 0x6C2A160
        public void GetCurrentProcess(){} // RVA: 0x6C2A340
        public void OnExited(){} // RVA: 0x6C2A450
        public void GetProcessHandle(){} // RVA: 0x6C2AC90 | overloaded x2
        public void OpenProcessHandle(){} // RVA: 0x6C2ACA0
        public void Refresh(){} // RVA: 0x6C2AD50
        public void SetProcessHandle(){} // RVA: 0x6C2AE10
        public void SetProcessId(){} // RVA: 0x6C2AE80
        public void Start(){} // RVA: 0x6C2B330 | overloaded x3
        public void Kill(){} // RVA: 0x6C2B4F0
        public void StopWatchingForExit(){} // RVA: 0x6C2B5E0
        public void ToString(){} // RVA: 0x6C2B830
        public void ProcessName_icall(){} // RVA: 0x6C2B950
        public void ProcessName_internal(){} // RVA: 0x6C2B9F0
        public void get_ProcessName(){} // RVA: 0x6C2BB70
        public void ShellExecuteEx_internal(){} // RVA: 0x2DD320
        public void CreateProcess_internal(){} // RVA: 0x2DD320
        public void StartWithShellExecuteEx(){} // RVA: 0x6C2BE50
        public void CreatePipe(){} // RVA: 0x6C2C280
        public void get_IsWindows(){} // RVA: 0x5E67A40
        public void StartWithCreateProcess(){} // RVA: 0x6C2C6A0
        public void FillUserInfo(){} // RVA: 0x6C2D8B0
        public void RaiseOnExited(){} // RVA: 0x6C2DB90
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
        public void .ctor(){} // RVA: 0x6C2DE20 | overloaded x2
        public void get_ArgumentList(){} // RVA: 0x6C2DEE0
        public void get_Arguments(){} // RVA: 0x6C2DFB0
        public void set_Arguments(){} // RVA: 0x343E80
        public void get_EnvironmentVariables(){} // RVA: 0x6C2E010
        public void get_RedirectStandardInput(){} // RVA: 0x4EC4D70
        public void get_RedirectStandardOutput(){} // RVA: 0x5AF9770
        public void get_RedirectStandardError(){} // RVA: 0x6AC9640
        public void get_StandardErrorEncoding(){} // RVA: 0x4C7C50
        public void get_StandardOutputEncoding(){} // RVA: 0x3A5590
        public void get_UseShellExecute(){} // RVA: 0x398C00
        public void get_UserName(){} // RVA: 0x6C2E660
        public void get_Password(){} // RVA: 0x3A5500
        public void get_Domain(){} // RVA: 0x6C2E6C0
        public void get_LoadUserProfile(){} // RVA: 0x3A5570
        public void get_FileName(){} // RVA: 0x6C2E720
        public void get_WorkingDirectory(){} // RVA: 0x6C2E780
        public void get_HaveEnvVars(){} // RVA: 0x6C2E7E0
        public void get_StandardInputEncoding(){} // RVA: 0xA1C130
        public void .cctor(){} // RVA: 0x6C2E7F0
    }

    public class ProcessThreadCollection
    {
    }

    public class ProcessThreadTimes
    {
        // ── Methods ──
        public void get_StartTime(){} // RVA: 0x6C2DCF0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ProcessWaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C2E8A0
    }

    public class ResolvedMethod
    {
        public object Name;
        public object ResolvedType;
        public object Prefix;
        public object IsDynamicType;

        // ── Methods ──
        public void get_MethodBase(){} // RVA: 0x2F8380
        public void set_MethodBase(){} // RVA: 0x2DEE30
        public void get_DeclaringType(){} // RVA: 0x2E07C0
        public void set_DeclaringType(){} // RVA: 0x343E80
        public void get_IsAsync(){} // RVA: 0x3CB9D0
        public void set_IsAsync(){} // RVA: 0x3CB9E0
        public void get_IsLambda(){} // RVA: 0x6BB3A0
        public void set_IsLambda(){} // RVA: 0xB265D0
        public void get_ReturnParameter(){} // RVA: 0x30B130
        public void set_ReturnParameter(){} // RVA: 0x2DEE90
        public void get_Name(){} // RVA: 0x6374D0
        public void set_Name(){} // RVA: 0x30B890
        public void get_Ordinal(){} // RVA: 0x4976A0
        public void set_Ordinal(){} // RVA: 0xF501D0
        public void get_GenericArguments(){} // RVA: 0x35A740
        public void set_GenericArguments(){} // RVA: 0x305200
        public void get_ResolvedGenericArguments(){} // RVA: 0x358730
        public void set_ResolvedGenericArguments(){} // RVA: 0x358740
        public void get_SubMethodBase(){} // RVA: 0x37E0E0
        public void set_SubMethodBase(){} // RVA: 0x4354D0
        public void get_SubMethod(){} // RVA: 0x3A5500
        public void set_SubMethod(){} // RVA: 0x3A5510
        public void get_Parameters(){} // RVA: 0x37B370
        public void set_Parameters(){} // RVA: 0x37B380
        public void get_SubMethodParameters(){} // RVA: 0x358D50
        public void set_SubMethodParameters(){} // RVA: 0x358D60
        public void get_RecurseCount(){} // RVA: 0x10E5CF0
        public void set_RecurseCount(){} // RVA: 0x475080
        public void IsSequentialEquivalent(){} // RVA: 0x6453540
        public void ToString(){} // RVA: 0x6453710
        public void Append(){} // RVA: 0x64537B0 | overloaded x2
        public void AppendDeclaringTypeName(){} // RVA: 0x64541F0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ResolvedParameter
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
        public void set_Name(){} // RVA: 0x2DEE30
        public void get_ResolvedType(){} // RVA: 0x2E07C0
        public void set_ResolvedType(){} // RVA: 0x343E80
        public void get_Prefix(){} // RVA: 0x30B0C0
        public void set_Prefix(){} // RVA: 0x30B0D0
        public void get_IsDynamicType(){} // RVA: 0x6E8A80
        public void set_IsDynamicType(){} // RVA: 0x6E8B80
        public void .ctor(){} // RVA: 0x343E80
        public void ToString(){} // RVA: 0x64542B0
        public void Append(){} // RVA: 0x6454340
        public void AppendTypeName(){} // RVA: 0x64545D0
    }

    public class StackFrame
    {
        // ── Methods ──
        public void get_frame_info(){} // RVA: 0x5DF62C0
        public void .ctor(){} // RVA: 0x5DF6380 | overloaded x3
        public void GetFileLineNumber(){} // RVA: 0xFDC9F0
        public void GetFileColumnNumber(){} // RVA: 0x891AF0
        public void GetFileName(){} // RVA: 0x6374D0
        public void GetSecureFileName(){} // RVA: 0x5DF6440
        public void GetILOffset(){} // RVA: 0x32A5C0
        public void GetMethod(){} // RVA: 0x30B130
        public void GetNativeOffset(){} // RVA: 0x8ABED0
        public void GetMethodAddress(){} // RVA: 0x2E07C0
        public void GetMethodIndex(){} // RVA: 0x760030
        public void GetInternalMethodName(){} // RVA: 0x35A740
        public void ToString(){} // RVA: 0x5DF64B0
    }

    public class StackTrace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x11
        public void init_frames(){} // RVA: 0x5DF6730
        public void get_trace(){} // RVA: 0x5DF69D0
        public void get_FrameCount(){} // RVA: 0x37E2650
        public void GetFrame(){} // RVA: 0x5DF6DA0
        public void GetFrames(){} // RVA: 0x5DF6E10
        public void GetAotId(){} // RVA: 0x5DF6FD0
        public void AddFrames(){} // RVA: 0x5DF7080
        public void GetFullNameForStackTrace(){} // RVA: 0x5DF7630
        public void ConvertAsyncStateMachineMethod(){} // RVA: 0x5DF7DD0
        public void ToString(){} // RVA: 0x5DF8220 | overloaded x2
    }

    public class StackTraceHiddenAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Stopwatch
    {
        // ── Methods ──
        public void GetTimestamp(){} // RVA: 0x5F40750
        public void StartNew(){} // RVA: 0x6C2F4A0
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Elapsed(){} // RVA: 0x6C2F540
        public void get_ElapsedMilliseconds(){} // RVA: 0x6C2F650
        public void get_ElapsedTicks(){} // RVA: 0x6C2F7A0
        public void get_IsRunning(){} // RVA: 0x3CB9D0
        public void Reset(){} // RVA: 0x6C2F810
        public void Start(){} // RVA: 0x6C2F820
        public void Stop(){} // RVA: 0x6C2F880
        public void Restart(){} // RVA: 0x6C2F900
        public void .cctor(){} // RVA: 0x6C2F960
    }

    public class StringBuilderExtentions
    {
        // ── Methods ──
        public void AppendDemystified(){} // RVA: 0x6454640
        public void AppendInnerException(){} // RVA: 0x6454AF0
    }

    public class Switch
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C23F00 | overloaded x2
        public void _pruneCachedSwitches(){} // RVA: 0x6C242F0
        public void .cctor(){} // RVA: 0x6C24950
    }

    public class SwitchLevelAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C24A30
        public void set_SwitchLevelType(){} // RVA: 0x6C24A30
    }

    public class SynchronizedList`1
    {
        public object countAll;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void Add(){} // RVA: 0x283FA0
        public void AddIfNotExist(){} // RVA: 0x283FA0
        public void Remove(){} // RVA: 0x283FA0
        public void get_Count(){} // RVA: 0xD840
        public void EnumWithAction(){} // RVA: 0x2DC60
    }

    public class Trace
    {
        public object Callstack;
        public object LogicalOperationStack;
        public object DateTime;

        // ── Methods ──
        public void get_Listeners(){} // RVA: 0x6C24B20
        public void get_AutoFlush(){} // RVA: 0x6C24B70
        public void get_CorrelationManager(){} // RVA: 0x6C24C00
        public void WriteLine(){} // RVA: 0x6C24CE0
    }

    public class TraceEventCache
    {
        // ── Methods ──
        public void get_Callstack(){} // RVA: 0x6C24D30
        public void get_LogicalOperationStack(){} // RVA: 0x6C24E10
        public void get_DateTime(){} // RVA: 0x6C24F00
        public void get_ProcessId(){} // RVA: 0x6C24FE0
        public void get_ThreadId(){} // RVA: 0x6C25030
        public void get_Timestamp(){} // RVA: 0x6C251B0
        public void InitProcessInfo(){} // RVA: 0x6C25210
        public void GetProcessId(){} // RVA: 0x6C24FE0
        public void GetThreadId(){} // RVA: 0x5EFDCD0
        public void .ctor(){} // RVA: 0x6C25390
    }

    public class TraceFilter
    {
        // ── Methods ──
        public void ShouldTrace(){} // RVA: 0x6C25400 | overloaded x2
    }

    public class TraceInternal
    {
        public object IsThreadSafe;
        public object IndentLevel;
        public object IndentSize;
        public object Filter;
        public object NeedIndent;

        // ── Methods ──
        public void get_Listeners(){} // RVA: 0x6C25450
        public void get_AutoFlush(){} // RVA: 0x6C25950
        public void get_UseGlobalLock(){} // RVA: 0x6C259B0
        public void get_IndentLevel(){} // RVA: 0x6C25A10
        public void get_IndentSize(){} // RVA: 0x6C25AB0
        public void InitializeSettings(){} // RVA: 0x2DD310
        public void WriteLine(){} // RVA: 0x6C25B10
        public void .cctor(){} // RVA: 0x6C26390
    }

    public class TraceListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C264C0
        public void get_IsThreadSafe(){} // RVA: 0x2DD320
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
        public void Flush(){} // RVA: 0x2DD310
        public void set_IndentLevel(){} // RVA: 0x6C26590
        public void set_IndentSize(){} // RVA: 0x6C265B0
        public void get_Filter(){} // RVA: 0x6374D0
        public void get_NeedIndent(){} // RVA: 0x2F87C0
        public void set_NeedIndent(){} // RVA: 0x4D7670
        public void get_TraceOutputOptions(){} // RVA: 0x760030
        public void Write(){} // RVA: 0x24B10
        public void WriteIndent(){} // RVA: 0x6C26670
        public void WriteLine(){} // RVA: 0x24B10
        public void TraceEvent(){} // RVA: 0x6C26730
        public void WriteHeader(){} // RVA: 0x6C26950
        public void WriteFooter(){} // RVA: 0x6C26AF0
        public void IsEnabled(){} // RVA: 0x6C27550
    }

    public class TraceListenerCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C27560
        public void get_Count(){} // RVA: 0x5DFC050
        public void Add(){} // RVA: 0x6C276A0
        public void Clear(){} // RVA: 0x6C27880
        public void GetEnumerator(){} // RVA: 0x5BCD010
        public void InitializeListener(){} // RVA: 0x6C27920
        public void RemoveAt(){} // RVA: 0x6C27AB0
        public void System.Collections.IList.get_Item(){} // RVA: 0x6C27C70
        public void System.Collections.IList.set_Item(){} // RVA: 0x6C27CA0
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IList.Add(){} // RVA: 0x6C27DE0
        public void System.Collections.IList.Contains(){} // RVA: 0x5DFC5C0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x5DFC860
        public void System.Collections.IList.Insert(){} // RVA: 0x6C28080
        public void System.Collections.IList.Remove(){} // RVA: 0x6C28320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x1A3F520
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x3C2850
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x6C284E0
    }

    public class TraceSwitch
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C286A0
    }

    public class TypeNameHelper
    {
        // ── Methods ──
        public void GetTypeDisplayName(){} // RVA: 0x6454BA0
        public void AppendTypeDisplayName(){} // RVA: 0x6454C80
        public void GetTypeNameForGenericType(){} // RVA: 0x6454D10
        public void ProcessType(){} // RVA: 0x6454E30
        public void ProcessArrayType(){} // RVA: 0x6455420
        public void ProcessGenericType(){} // RVA: 0x6455630
        public void .cctor(){} // RVA: 0x6455C60
    }

    public class ValueTupleResolvedParameter
    {
        // ── Methods ──
        public void get_TupleNames(){} // RVA: 0x6374D0
        public void .ctor(){} // RVA: 0x6456AC0
        public void AppendTypeName(){} // RVA: 0x6456B70
        public void AppendValueTupleParameterName(){} // RVA: 0x6456E60
    }

}