// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics
// Classes: 57
// Methods: 430

namespace ThirdParty.DotNet.System.Diagnostics
{
    public class Activity : Object
    {
        // ── Methods ──
        public void get_Source(){} // RVA: 0x7A82C2060
        public void get_Parent(){} // RVA: 0x7A825E100
        public void get_Duration(){} // RVA: 0x7A81163D0
        public void set_Duration(){} // RVA: 0x7A887B550
        public void get_StartTimeUtc(){} // RVA: 0x7A8555100
        public void get_Id(){} // RVA: 0x7AE5C8600
        public void get_ParentId(){} // RVA: 0x7AE5C87D0
        public void get_RootId(){} // RVA: 0x7AE5C89C0
        public void get_TagObjects(){} // RVA: 0x7AE5C8AA0
        public void get_Baggage(){} // RVA: 0x7AE5C8B10
        public void SetEndTime(){} // RVA: 0x7AE5C8BB0
        public void Stop(){} // RVA: 0x7AE5C8DD0
        public void get_TraceStateString(){} // RVA: 0x7AE5C9290
        public void get_SpanId(){} // RVA: 0x7AE5C92B0
        public void get_TraceId(){} // RVA: 0x7AE5C93F0
        public void get_ActivityTraceFlags(){} // RVA: 0x7AE5C9470
        public void set_ActivityTraceFlags(){} // RVA: 0x7AE5C94A0
        public void get_ParentSpanId(){} // RVA: 0x7AE5C94B0
        public void IsW3CId(){} // RVA: 0x7AE5C9740
        public void Dispose(){} // RVA: 0x7A80D7310
        public void SetCustomProperty(){} // RVA: 0x7AE5C9840
        public void GetCustomProperty(){} // RVA: 0x7AE5C9AE0
        public void NotifyError(){} // RVA: 0x7AE5C9C80
        public void GetRootId(){} // RVA: 0x7AE5C9CC0
        public void GetRandomNumber(){} // RVA: 0x7AE5C9D40
        public void TrySetTraceIdFromParent(){} // RVA: 0x7AE5C9D80
        public void TrySetTraceFlagsFromParent(){} // RVA: 0x7AE5CA1E0
        public void get_W3CIdFlagsSet(){} // RVA: 0x7AE5CA430
        public void get_IsStopped(){} // RVA: 0x7AE5CA440
        public void set_IsStopped(){} // RVA: 0x7AE5CA450
        public void get_IdFormat(){} // RVA: 0x7AE5CA480
        public void get_Current(){} // RVA: 0x7AE5CA490
        public void SetCurrent(){} // RVA: 0x7AE5CA510
        public void GetUtcNow(){} // RVA: 0x7AE5CA690
        public void .cctor(){} // RVA: 0x7AE5CA6E0
        public void <get_Baggage>g__Iterate|87_0(){} // RVA: 0x7AE5CAC30
    }

    public class ActivityChangedEventArgs : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7661E00
        public void set_Previous(){} // RVA: 0x7A7637E60
        public void set_Current(){} // RVA: 0x7A765F010
    }

    public class ActivityContext : ValueType
    {
        // ── Methods ──
        public void get_TraceId(){} // RVA: 0x7A765F710
        public void get_SpanId(){} // RVA: 0x7A765F080
        public void get_TraceFlags(){} // RVA: 0x7A7677B20
        public void get_TraceState(){} // RVA: 0x7A767FF40
        public void get_IsRemote(){} // RVA: 0x7A7690A70
        public void Equals(){} // RVA: 0x7A7E89460
        public void op_Equality(){} // RVA: 0x7AE5CBCD0
        public void GetHashCode(){} // RVA: 0x7A7E89510
    }

    public class ActivityEvent : ValueType
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AE5CBEA0
    }

    public class ActivityLink : ValueType
    {
        // ── Methods ──
        public void get_Context(){} // RVA: 0x7A76C4680
        public void get_Tags(){} // RVA: 0x7A765F710
        public void Equals(){} // RVA: 0x7A7E89570
        public void op_Equality(){} // RVA: 0x7AE5CC100
        public void GetHashCode(){} // RVA: 0x7A7E89620
    }

    public class ActivityListener : Object
    {
        // ── Methods ──
        public void get_ActivityStopped(){} // RVA: 0x7A80F2570
        public void get_ShouldListenTo(){} // RVA: 0x7A80DA7B0
        public void Dispose(){} // RVA: 0x7AE5CC4F0
    }

    public class ActivitySource : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5CC540
        public void Dispose(){} // RVA: 0x7AE5CC8A0
        public void AddListener(){} // RVA: 0x7AE5CC980
        public void DetachListener(){} // RVA: 0x7AE5CCA80
        public void NotifyActivityStop(){} // RVA: 0x7AE5CCC70
        public void .cctor(){} // RVA: 0x7AE5CCDE0
    }

    public class ActivitySpanId : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7637E60
        public void CreateFromString(){} // RVA: 0x7AE5CB820
        public void ToHexString(){} // RVA: 0x7A7E88F20
        public void ToString(){} // RVA: 0x7A7E88F20
        public void Equals(){} // RVA: 0x7A7E88F70
        public void GetHashCode(){} // RVA: 0x7A7E89030
    }

    public class ActivityTraceId : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7637E60
        public void CreateFromString(){} // RVA: 0x7AE5CB3B0
        public void ToHexString(){} // RVA: 0x7A7E88DB0
        public void ToString(){} // RVA: 0x7A7E88DB0
        public void Equals(){} // RVA: 0x7A7E88E00
        public void GetHashCode(){} // RVA: 0x7A7E88EC0
        public void HexByteFromChars(){} // RVA: 0x7AE5CB6B0
        public void IsLowerCaseHexAndNotAllZeros(){} // RVA: 0x7AE5CB770
    }

    public class AsyncStreamReader : Object
    {
        // ── Methods ──
        public void Close(){} // RVA: 0x7A8125330
        public void Dispose(){} // RVA: 0x7AEA177C0
        public void CancelOperation(){} // RVA: 0x7A8F567E0
    }

    public class BooleanSwitch : Switch
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA12DE0
    }

    public class ConditionalAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
    }

    public class CorrelationManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_LogicalOperationStack(){} // RVA: 0x7AEA12E80
        public void GetLogicalOperationStack(){} // RVA: 0x7AEA12E90
    }

    public class DebuggableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
    }

    public class Debugger : Object
    {
        // ── Methods ──
        public void get_IsAttached(){} // RVA: 0x7ADBE4B40
        public void IsAttached_internal(){} // RVA: 0x7ADBE4B90
        public void IsLogging(){} // RVA: 0x7A80D7320
        public void Log_icall(){} // RVA: 0x7A80D7310
        public void Log(){} // RVA: 0x7ADBE4BB0
        public void NotifyOfCrossThreadDependency(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7ADBE4C00
    }

    public class DebuggerBrowsableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADBE4800
    }

    public class DebuggerDisplayAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADBE4980
        public void set_Name(){} // RVA: 0x7A80D8E20
        public void set_Type(){} // RVA: 0x7A81052D0
    }

    public class DebuggerHiddenAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DebuggerNonUserCodeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DebuggerStepThroughAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DebuggerTypeProxyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADBE4870
    }

    public class DefaultTraceListener : TraceListener
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AEA1D7D0
        public void GetPrefix(){} // RVA: 0x7AEA1DA70
        public void .ctor(){} // RVA: 0x7AEA1DAF0
        public void get_LogFileName(){} // RVA: 0x7A8292C30
        public void WriteWindowsDebugString(){} // RVA: 0x7AEA1DB80
        public void WriteDebugString(){} // RVA: 0x7AEA1DB90
        public void WriteMonoTrace(){} // RVA: 0x7AEA1DC30
        public void WritePrefix(){} // RVA: 0x7AEA1DE50
        public void WriteImpl(){} // RVA: 0x7AEA1DEE0
        public void WriteLogFile(){} // RVA: 0x7AEA1E070
        public void Write(){} // RVA: 0x7AEA1E290
        public void WriteLine(){} // RVA: 0x7AEA1E2A0
    }

    public class DiagEnumerator`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void get_Current(){} // RVA: 0x7A8051B10
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7A7E00680
        public void MoveNext(){} // RVA: 0x7A7E01900
        public void Reset(){} // RVA: 0x7A7E18770
        public void Dispose(){} // RVA: 0x7A7E18770
        public void .cctor(){} // RVA: 0x7A7E187D0
    }

    public class DiagNode`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8051B10
    }

    public class DiagnosticSourceEventSource : EventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5CD2E0
        public void .cctor(){} // RVA: 0x7AE5CD3F0
    }

    public class DiagnosticsConfigurationHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C2B70
        public void Create(){} // RVA: 0x7AE9C2BA0
    }

    public class EnhancedStackFrame : StackFrame
    {
        // ── Methods ──
        public void get_StackFrame(){} // RVA: 0x7A81A0050
        public void get_IsRecursive(){} // RVA: 0x7AE23A950
        public void set_IsRecursive(){} // RVA: 0x7AE23A970
        public void get_MethodInfo(){} // RVA: 0x7A8175DF0
        public void .ctor(){} // RVA: 0x7AE23A990
        public void IsEquivalent(){} // RVA: 0x7AE23AAF0
        public void GetFileColumnNumber(){} // RVA: 0x7A8A22410
        public void GetFileLineNumber(){} // RVA: 0x7A8355950
        public void GetFileName(){} // RVA: 0x7A8152D80
        public void GetILOffset(){} // RVA: 0x7AE23AB80
        public void GetMethod(){} // RVA: 0x7AE23ABB0
        public void GetNativeOffset(){} // RVA: 0x7AE23ABE0
        public void ToString(){} // RVA: 0x7AE23AC10
    }

    public class EnhancedStackTrace : StackTrace
    {
        // ── Methods ──
        public void Current(){} // RVA: 0x7AE23AC40
        public void .ctor(){} // RVA: 0x7AE23AF50
        public void get_FrameCount(){} // RVA: 0x7AE23B060
        public void GetFrame(){} // RVA: 0x7AE23B0B0
        public void GetFrames(){} // RVA: 0x7AE23BAF0
        public void ToString(){} // RVA: 0x7AE23B180
        public void Append(){} // RVA: 0x7AE23B250
        public void GetEnumerator(){} // RVA: 0x7AE23B460
        public void System.Collections.Generic.IEnumerable<System.Diagnostics.EnhancedStackFrame>.GetEnumerator(){} // RVA: 0x7AE23B4A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AE23B590
        public void TryGetFullPath(){} // RVA: 0x7AE23B680
        public void .cctor(){} // RVA: 0x7AE23B740
        public void GetMethodDisplayString(){} // RVA: 0x7AE23BF60
        public void IsFSharpAsync(){} // RVA: 0x7AE23D100
        public void TryResolveGeneratedName(){} // RVA: 0x7AE23D270
        public void TryResolveSourceMethod(){} // RVA: 0x7AE23DDC0
        public void GetOrdinal(){} // RVA: 0x7AE23E400
        public void GetMatchHint(){} // RVA: 0x7AE23E760
        public void TryParseGeneratedName(){} // RVA: 0x7AE23E870
        public void IndexOfBalancedParenthesis(){} // RVA: 0x7AE23EBB0
        public void GetPrefix(){} // RVA: 0x7AE23EC50
        public void GetParameter(){} // RVA: 0x7AE23EE50
        public void GetValueTupleParameter(){} // RVA: 0x7AE23F370
        public void GetValueTupleParameterName(){} // RVA: 0x7AE23F530
        public void ShowInStackTrace(){} // RVA: 0x7AE23F770
        public void IsStackTraceHidden(){} // RVA: 0x7AE2406F0
        public void TryResolveStateMachineMethod(){} // RVA: 0x7AE240B50
        public void <TryResolveStateMachineMethod>g__GetDeclaredMethods|33_0(){} // RVA: 0x7AE241070
    }

    public class ExceptionExtensions : Object
    {
        // ── Methods ──
        public void SetStackTracesString(){} // RVA: 0x7AE241340
        public void Demystify(){} // RVA: 0x7A8051B10
        public void ToStringDemystified(){} // RVA: 0x7AE2413C0
        public void .cctor(){} // RVA: 0x7AE241450
    }

    public class MonitoringDescriptionAttribute : DescriptionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA1E2F0
        public void get_Description(){} // RVA: 0x7A80F2570
    }

    public class Process : Component
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA17D90
        public void get_Associated(){} // RVA: 0x7AEA17E70
        public void get_HasExited(){} // RVA: 0x7AEA17E80
        public void GetProcessTimes(){} // RVA: 0x7AEA18230
        public void get_Handle(){} // RVA: 0x7AEA18480
        public void get_Id(){} // RVA: 0x7AEA18550
        public void get_StartInfo(){} // RVA: 0x7AEA18570
        public void set_StartInfo(){} // RVA: 0x7AEA186D0
        public void get_StartTime(){} // RVA: 0x7AEA18780
        public void get_SynchronizingObject(){} // RVA: 0x7AEA18800
        public void ReleaseProcessHandle(){} // RVA: 0x7AEA189D0
        public void CompletionCallback(){} // RVA: 0x7AEA18A00
        public void Dispose(){} // RVA: 0x7AEA18A20
        public void Close(){} // RVA: 0x7AEA18A70
        public void EnsureState(){} // RVA: 0x7AEA18F00
        public void EnsureWatchingForExit(){} // RVA: 0x7AEA19180
        public void GetCurrentProcess(){} // RVA: 0x7AEA19330
        public void OnExited(){} // RVA: 0x7AEA19440
        public void GetProcessHandle(){} // RVA: 0x7AEA19CA0
        public void OpenProcessHandle(){} // RVA: 0x7AEA19CB0
        public void Refresh(){} // RVA: 0x7AEA19D60
        public void SetProcessHandle(){} // RVA: 0x7AEA19E20
        public void SetProcessId(){} // RVA: 0x7AEA19E90
        public void Start(){} // RVA: 0x7AEA1A340
        public void Kill(){} // RVA: 0x7AEA1A500
        public void StopWatchingForExit(){} // RVA: 0x7AEA1A5E0
        public void ToString(){} // RVA: 0x7AEA1A800
        public void ProcessName_icall(){} // RVA: 0x7AEA1A920
        public void ProcessName_internal(){} // RVA: 0x7AEA1A9C0
        public void get_ProcessName(){} // RVA: 0x7AEA1AB40
        public void ShellExecuteEx_internal(){} // RVA: 0x7A80D7320
        public void CreateProcess_internal(){} // RVA: 0x7A80D7320
        public void StartWithShellExecuteEx(){} // RVA: 0x7AEA1AE10
        public void CreatePipe(){} // RVA: 0x7AEA1B250
        public void get_IsWindows(){} // RVA: 0x7ADC565D0
        public void StartWithCreateProcess(){} // RVA: 0x7AEA1B5E0
        public void FillUserInfo(){} // RVA: 0x7AEA1C7F0
        public void RaiseOnExited(){} // RVA: 0x7AEA1CAC0
    }

    public class ProcessStartInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA1CD10
        public void get_ArgumentList(){} // RVA: 0x7AEA1CDD0
        public void get_Arguments(){} // RVA: 0x7AEA1CEA0
        public void set_Arguments(){} // RVA: 0x7A813E420
        public void get_EnvironmentVariables(){} // RVA: 0x7AEA1CF00
        public void get_RedirectStandardInput(){} // RVA: 0x7ACF04410
        public void get_RedirectStandardOutput(){} // RVA: 0x7AD8E6CE0
        public void get_RedirectStandardError(){} // RVA: 0x7AE8B9BA0
        public void get_StandardErrorEncoding(){} // RVA: 0x7A82C2060
        public void get_StandardOutputEncoding(){} // RVA: 0x7A81A00E0
        public void get_UseShellExecute(){} // RVA: 0x7A8193790
        public void get_UserName(){} // RVA: 0x7AEA1D530
        public void get_Password(){} // RVA: 0x7A81A0050
        public void get_Domain(){} // RVA: 0x7AEA1D590
        public void get_LoadUserProfile(){} // RVA: 0x7A81A00C0
        public void get_FileName(){} // RVA: 0x7AEA1D5F0
        public void get_WorkingDirectory(){} // RVA: 0x7AEA1D650
        public void get_HaveEnvVars(){} // RVA: 0x7AEA1D6B0
        public void get_StandardInputEncoding(){} // RVA: 0x7A87D9480
        public void .cctor(){} // RVA: 0x7AEA1D6C0
    }

    public class ProcessThreadTimes : Object
    {
        // ── Methods ──
        public void get_StartTime(){} // RVA: 0x7AEA1CBE0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ProcessWaitHandle : WaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA1D770
    }

    public class ResolvedMethod : Object
    {
        // ── Methods ──
        public void get_MethodBase(){} // RVA: 0x7A80F2570
        public void set_MethodBase(){} // RVA: 0x7A80D8E20
        public void get_DeclaringType(){} // RVA: 0x7A80DA7B0
        public void set_DeclaringType(){} // RVA: 0x7A813E420
        public void get_IsAsync(){} // RVA: 0x7A81C68D0
        public void set_IsAsync(){} // RVA: 0x7A81C68E0
        public void get_IsLambda(){} // RVA: 0x7A8477E00
        public void set_IsLambda(){} // RVA: 0x7A88C2D40
        public void get_ReturnParameter(){} // RVA: 0x7A8105330
        public void set_ReturnParameter(){} // RVA: 0x7A80D8E80
        public void get_Name(){} // RVA: 0x7A83F69F0
        public void set_Name(){} // RVA: 0x7A8105A90
        public void get_Ordinal(){} // RVA: 0x7A8292C30
        public void set_Ordinal(){} // RVA: 0x7A82C26E0
        public void get_GenericArguments(){} // RVA: 0x7A8154D80
        public void set_GenericArguments(){} // RVA: 0x7A80FF440
        public void get_ResolvedGenericArguments(){} // RVA: 0x7A8152D80
        public void set_ResolvedGenericArguments(){} // RVA: 0x7A8152D90
        public void get_SubMethodBase(){} // RVA: 0x7A8178B90
        public void set_SubMethodBase(){} // RVA: 0x7A8230620
        public void get_SubMethod(){} // RVA: 0x7A81A0050
        public void set_SubMethod(){} // RVA: 0x7A81A0060
        public void get_Parameters(){} // RVA: 0x7A8175DF0
        public void set_Parameters(){} // RVA: 0x7A8175E00
        public void get_SubMethodParameters(){} // RVA: 0x7A8153390
        public void set_SubMethodParameters(){} // RVA: 0x7A81533A0
        public void get_RecurseCount(){} // RVA: 0x7A8EA8210
        public void set_RecurseCount(){} // RVA: 0x7A8270510
        public void IsSequentialEquivalent(){} // RVA: 0x7AE2415B0
        public void ToString(){} // RVA: 0x7AE241780
        public void Append(){} // RVA: 0x7AE241820
        public void AppendDeclaringTypeName(){} // RVA: 0x7AE242260
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ResolvedParameter : Object
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A80F2570
        public void set_Name(){} // RVA: 0x7A80D8E20
        public void get_ResolvedType(){} // RVA: 0x7A80DA7B0
        public void set_ResolvedType(){} // RVA: 0x7A813E420
        public void get_Prefix(){} // RVA: 0x7A81052C0
        public void set_Prefix(){} // RVA: 0x7A81052D0
        public void get_IsDynamicType(){} // RVA: 0x7A84A5BD0
        public void set_IsDynamicType(){} // RVA: 0x7A84A5CD0
        public void .ctor(){} // RVA: 0x7A813E420
        public void ToString(){} // RVA: 0x7AE242320
        public void Append(){} // RVA: 0x7AE2423B0
        public void AppendTypeName(){} // RVA: 0x7AE242640
    }

    public class StackFrame : Object
    {
        // ── Methods ──
        public void get_frame_info(){} // RVA: 0x7ADBE4CB0
        public void .ctor(){} // RVA: 0x7ADBE4D70
        public void GetFileLineNumber(){} // RVA: 0x7A8D863F0
        public void GetFileColumnNumber(){} // RVA: 0x7A864E8D0
        public void GetFileName(){} // RVA: 0x7A83F69F0
        public void GetSecureFileName(){} // RVA: 0x7ADBE4E30
        public void GetILOffset(){} // RVA: 0x7A8124910
        public void GetMethod(){} // RVA: 0x7A8105330
        public void GetNativeOffset(){} // RVA: 0x7A8668BC0
        public void GetMethodAddress(){} // RVA: 0x7A80DA7B0
        public void GetMethodIndex(){} // RVA: 0x7A851DB90
        public void GetInternalMethodName(){} // RVA: 0x7A8154D80
        public void ToString(){} // RVA: 0x7ADBE4EA0
    }

    public class StackFrame[] : Array
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

    public class StackTrace : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void init_frames(){} // RVA: 0x7ADBE5120
        public void get_trace(){} // RVA: 0x7ADBE53C0
        public void get_FrameCount(){} // RVA: 0x7AB5CF130
        public void GetFrame(){} // RVA: 0x7ADBE5890
        public void GetFrames(){} // RVA: 0x7ADBE5900
        public void GetAotId(){} // RVA: 0x7ADBE5AC0
        public void AddFrames(){} // RVA: 0x7ADBE5B70
        public void GetFullNameForStackTrace(){} // RVA: 0x7ADBE6120
        public void ConvertAsyncStateMachineMethod(){} // RVA: 0x7ADBE68D0
        public void ToString(){} // RVA: 0x7ADBE6D30
    }

    public class StackTraceHiddenAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class StackTraceHiddenAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class StackTraceHiddenAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class StackTrace[] : Array
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

    public class Stopwatch : Object
    {
        // ── Methods ──
        public void GetTimestamp(){} // RVA: 0x7ADD2F1B0
        public void StartNew(){} // RVA: 0x7AEA1E390
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_Elapsed(){} // RVA: 0x7AEA1E430
        public void get_ElapsedMilliseconds(){} // RVA: 0x7AEA1E540
        public void get_ElapsedTicks(){} // RVA: 0x7AEA1E690
        public void get_IsRunning(){} // RVA: 0x7A81C68D0
        public void Reset(){} // RVA: 0x7AEA1E700
        public void Start(){} // RVA: 0x7AEA1E710
        public void Stop(){} // RVA: 0x7AEA1E770
        public void Restart(){} // RVA: 0x7AEA1E7F0
        public void .cctor(){} // RVA: 0x7AEA1E850
    }

    public class StringBuilderExtentions : Object
    {
        // ── Methods ──
        public void AppendDemystified(){} // RVA: 0x7AE2426B0
        public void AppendInnerException(){} // RVA: 0x7AE242B60
    }

    public class Switch : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA131E0
        public void _pruneCachedSwitches(){} // RVA: 0x7AEA135A0
        public void .cctor(){} // RVA: 0x7AEA13BD0
    }

    public class SwitchLevelAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA13CB0
        public void set_SwitchLevelType(){} // RVA: 0x7AEA13CB0
    }

    public class SynchronizedList`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18770
        public void Add(){} // RVA: 0x7A8051B10
        public void AddIfNotExist(){} // RVA: 0x7A8051B10
        public void Remove(){} // RVA: 0x7A8051B10
        public void get_Count(){} // RVA: 0x7A7E00710
        public void EnumWithAction(){} // RVA: 0x7A7E18890
    }

    public class Trace : Object
    {
        // ── Methods ──
        public void get_Listeners(){} // RVA: 0x7AEA13DA0
        public void get_AutoFlush(){} // RVA: 0x7AEA13DF0
        public void get_CorrelationManager(){} // RVA: 0x7AEA13E80
        public void WriteLine(){} // RVA: 0x7AEA13F60
    }

    public class TraceEventCache : Object
    {
        // ── Methods ──
        public void get_Callstack(){} // RVA: 0x7AEA13FB0
        public void get_LogicalOperationStack(){} // RVA: 0x7AEA14090
        public void get_DateTime(){} // RVA: 0x7AEA14180
        public void get_ProcessId(){} // RVA: 0x7AEA14260
        public void get_ThreadId(){} // RVA: 0x7AEA142B0
        public void get_Timestamp(){} // RVA: 0x7AEA14430
        public void InitProcessInfo(){} // RVA: 0x7AEA14490
        public void GetProcessId(){} // RVA: 0x7AEA14260
        public void GetThreadId(){} // RVA: 0x7ADCEC960
        public void .ctor(){} // RVA: 0x7AEA14610
    }

    public class TraceFilter : Object
    {
        // ── Methods ──
        public void ShouldTrace(){} // RVA: 0x7AEA14680
    }

    public class TraceInternal : Object
    {
        // ── Methods ──
        public void get_Listeners(){} // RVA: 0x7AEA146D0
        public void get_AutoFlush(){} // RVA: 0x7AEA14BA0
        public void get_UseGlobalLock(){} // RVA: 0x7AEA14C00
        public void get_IndentLevel(){} // RVA: 0x7AEA14C60
        public void get_IndentSize(){} // RVA: 0x7AEA14D00
        public void InitializeSettings(){} // RVA: 0x7A80D7310
        public void WriteLine(){} // RVA: 0x7AEA14D60
        public void .cctor(){} // RVA: 0x7AEA15580
    }

    public class TraceListener : MarshalByRefObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA156B0
        public void get_IsThreadSafe(){} // RVA: 0x7A80D7320
        public void Dispose(){} // RVA: 0x7A80D7310
        public void Flush(){} // RVA: 0x7A80D7310
        public void set_IndentLevel(){} // RVA: 0x7AEA15780
        public void set_IndentSize(){} // RVA: 0x7AEA157A0
        public void get_Filter(){} // RVA: 0x7A83F69F0
        public void get_NeedIndent(){} // RVA: 0x7A80F29B0
        public void set_NeedIndent(){} // RVA: 0x7A9727920
        public void get_TraceOutputOptions(){} // RVA: 0x7A851DB90
        public void Write(){} // RVA: 0x7A7E18800
        public void WriteIndent(){} // RVA: 0x7AEA15860
        public void WriteLine(){} // RVA: 0x7A7E18800
        public void TraceEvent(){} // RVA: 0x7AEA15920
        public void WriteHeader(){} // RVA: 0x7AEA15B40
        public void WriteFooter(){} // RVA: 0x7AEA15CE0
        public void IsEnabled(){} // RVA: 0x7AEA16740
    }

    public class TraceListenerCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA16750
        public void get_Count(){} // RVA: 0x7ADBEAB80
        public void Add(){} // RVA: 0x7AEA16890
        public void Clear(){} // RVA: 0x7AEA16A40
        public void GetEnumerator(){} // RVA: 0x7AD9BABB0
        public void InitializeListener(){} // RVA: 0x7AEA16AE0
        public void RemoveAt(){} // RVA: 0x7AEA16C70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7AEA16DF0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7AEA16E20
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IList.Add(){} // RVA: 0x7AEA16F40
        public void System.Collections.IList.Contains(){} // RVA: 0x7ADBEB120
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ADBEB3C0
        public void System.Collections.IList.Insert(){} // RVA: 0x7AEA171A0
        public void System.Collections.IList.Remove(){} // RVA: 0x7AEA173F0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7A97F8BA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A81BD750
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AEA17580
    }

    public class TraceSwitch : Switch
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA17720
    }

    public class TypeNameHelper : Object
    {
        // ── Methods ──
        public void GetTypeDisplayName(){} // RVA: 0x7AE242C10
        public void AppendTypeDisplayName(){} // RVA: 0x7AE242CF0
        public void GetTypeNameForGenericType(){} // RVA: 0x7AE242D80
        public void ProcessType(){} // RVA: 0x7AE242EA0
        public void ProcessArrayType(){} // RVA: 0x7AE243490
        public void ProcessGenericType(){} // RVA: 0x7AE2436A0
        public void .cctor(){} // RVA: 0x7AE243CD0
    }

    public class ValueTupleResolvedParameter : ResolvedParameter
    {
        // ── Methods ──
        public void get_TupleNames(){} // RVA: 0x7A83F69F0
        public void .ctor(){} // RVA: 0x7AE244B30
        public void AppendTypeName(){} // RVA: 0x7AE244BE0
        public void AppendValueTupleParameterName(){} // RVA: 0x7AE244EC0
    }

}