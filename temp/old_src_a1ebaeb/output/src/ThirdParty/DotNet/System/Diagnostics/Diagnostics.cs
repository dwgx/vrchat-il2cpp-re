// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics
// Classes: 14
// Methods: 123

namespace ThirdParty.DotNet.System.Diagnostics
{
    public class DebuggableAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa89350c0
    }

    public class Debugger : Object
    {
        // ── Original Methods ──
        public void get_IsAttached(){} // RVA: 0x7ffaadfae9d0
        public void IsAttached_internal(){} // RVA: 0x7ffaadfaea20
        public void IsLogging(){} // RVA: 0x7ffaa8932320
        public void Log_icall(){} // RVA: 0x7ffaa8932310
        public void Log(){} // RVA: 0x7ffaadfaea40
        public void NotifyOfCrossThreadDependency(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaadfaea90
    }

    public class DebuggerDisplayAttribute : Attribute
    {
        public object type; // 0x34F38E20
        public object Name; // 0x17000797

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadfae810
        public void set_Name(){} // RVA: 0x7ffaa8933e30
        public void set_Type(){} // RVA: 0x7ffaa89600d0
    }

    public class DebuggerHiddenAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class DebuggerTypeProxyAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadfae700
    }

    public class DiagEnumerator`1 : ValueType
    {
        public object _currentNode; // 0x30E6E8D0
        public object Current; // 0x17000025

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void get_Current(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7ffaa86491d0
        public void MoveNext(){} // RVA: 0x7ffaa864a040
        public void Reset(){} // RVA: 0x7ffaa8660cc0
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
    }

    public class DiagNode`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
    }

    public class ExceptionExtensions : Object
    {
        // ── Original Methods ──
        public void Demystify(){} // RVA: 0x7ffaa887e5c0
        public void ToStringDemystified(){} // RVA: 0x7ffaae60b8d0
        public void .cctor(){} // RVA: 0x7ffaae60b960
        // ── Binary Analysis Named ──
        public void SetStackTracesString(){} // RVA: 0x7ffaae60b850
    }

    public class Process : Component
    {
        public object haveProcessHandle; // 0x35F7BD00
        public object machineName; // 0x35F7BD00
        public object modules; // 0x35F7BD00
        public object startInfo; // 0x35F7BD00
        public object onExited; // 0x35F7BD00
        public object signaled; // 0x35F7BD00
        public object registeredWaitHandle; // 0x35F7BD00
        public object standardOutput; // 0x35F7BD00
        public object disposed; // 0x35F7BD00
        public object inputStreamReadMode; // 0x35F7BD00
        public object process_name; // 0x35F7BD00
        public object Associated; // 0x1700011C
        public object HasExited; // 0x1700011D
        public object Handle; // 0x1700011E
        public object Id; // 0x1700011F
        public object StartInfo; // 0x17000120
        public object StartTime; // 0x17000121
        public object SynchronizingObject; // 0x17000122
        public object ProcessName; // 0x17000123
        public object IsWindows; // 0x17000124

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaede34a0
        public void .ctor(){} // RVA: 0x7ffaaede34a0
        public void get_Associated(){} // RVA: 0x7ffaaede3580
        public void get_HasExited(){} // RVA: 0x7ffaaede3590
        public void get_Handle(){} // RVA: 0x7ffaaede3bb0
        public void get_Id(){} // RVA: 0x7ffaaede3c80
        public void get_StartInfo(){} // RVA: 0x7ffaaede3ca0
        public void set_StartInfo(){} // RVA: 0x7ffaaede3e00
        public void get_StartTime(){} // RVA: 0x7ffaaede3eb0
        public void get_SynchronizingObject(){} // RVA: 0x7ffaaede3f30
        public void ReleaseProcessHandle(){} // RVA: 0x7ffaaede4100
        public void CompletionCallback(){} // RVA: 0x7ffaaede4130
        public void Dispose(){} // RVA: 0x7ffaaede4150
        public void Close(){} // RVA: 0x7ffaaede41a0
        public void EnsureState(){} // RVA: 0x7ffaaede4630
        public void EnsureWatchingForExit(){} // RVA: 0x7ffaaede48b0
        public void OnExited(){} // RVA: 0x7ffaaede4ba0
        public void OpenProcessHandle(){} // RVA: 0x7ffaaede53f0
        public void Refresh(){} // RVA: 0x7ffaaede54a0
        public void Start(){} // RVA: 0x7ffaaede5a80
        public void Start(){} // RVA: 0x7ffaaede5a80
        public void Start(){} // RVA: 0x7ffaaede5a80
        public void Kill(){} // RVA: 0x7ffaaede5c40
        public void StopWatchingForExit(){} // RVA: 0x7ffaaede5d30
        public void ToString(){} // RVA: 0x7ffaaede5f80
        public void ProcessName_icall(){} // RVA: 0x7ffaaede60a0
        public void ProcessName_internal(){} // RVA: 0x7ffaaede6140
        public void get_ProcessName(){} // RVA: 0x7ffaaede62c0
        public void ShellExecuteEx_internal(){} // RVA: 0x7ffaa8932320
        public void CreateProcess_internal(){} // RVA: 0x7ffaa8932320
        public void StartWithShellExecuteEx(){} // RVA: 0x7ffaaede65a0
        public void CreatePipe(){} // RVA: 0x7ffaaede69d0
        public void get_IsWindows(){} // RVA: 0x7ffaae0202c0
        public void StartWithCreateProcess(){} // RVA: 0x7ffaaede6df0
        public void FillUserInfo(){} // RVA: 0x7ffaaede8000
        public void RaiseOnExited(){} // RVA: 0x7ffaaede82e0
        // ── Binary Analysis Named ──
        public void GetProcessTimes(){} // RVA: 0x7ffaaede3940
        public void GetCurrentProcess(){} // RVA: 0x7ffaaede4a90
        public void GetProcessHandle(){} // RVA: 0x7ffaaede53e0
        public void GetProcessHandle(){} // RVA: 0x7ffaaede53e0
        public void SetProcessHandle(){} // RVA: 0x7ffaaede5560
        public void SetProcessId(){} // RVA: 0x7ffaaede55d0
    }

    public class ProcessWaitHandle : WaitHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaede8ff0
    }

    public class StackFrame : Object
    {
        public object nativeOffset; // 0x303178D0
        public object methodBase; // 0x303178D0
        public object columnNumber; // 0x303178D0

        // ── Original Methods ──
        public void get_frame_info(){} // RVA: 0x7ffaadfaeb40
        public void .ctor(){} // RVA: 0x7ffaadfaec00
        public void .ctor(){} // RVA: 0x7ffaadfaec00
        public void .ctor(){} // RVA: 0x7ffaadfaec00
        public void ToString(){} // RVA: 0x7ffaadfaed30
        // ── Binary Analysis Named ──
        public void GetFileLineNumber(){} // RVA: 0x7ffaa8fb82b0
        public void GetFileColumnNumber(){} // RVA: 0x7ffaa8de7460
        public void GetFileName(){} // RVA: 0x7ffaa8bfcc80
        public void GetSecureFileName(){} // RVA: 0x7ffaadfaecc0
        public void GetILOffset(){} // RVA: 0x7ffaa897f5c0
        public void GetMethod(){} // RVA: 0x7ffaa8960130
        public void GetNativeOffset(){} // RVA: 0x7ffaa8e046c0
        public void GetMethodAddress(){} // RVA: 0x7ffaa89357c0
        public void GetMethodIndex(){} // RVA: 0x7ffaa8aeced0
        public void GetInternalMethodName(){} // RVA: 0x7ffaa89af740
    }

    public class StackTrace : Object
    {
        public object frames; // 0x30317AB0
        public object isAotidSet; // 0x30317AB0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void init_frames(){} // RVA: 0x7ffaadfaefb0
        public void get_trace(){} // RVA: 0x7ffaadfaf250
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void get_FrameCount(){} // RVA: 0x7ffaabb1f180
        public void AddFrames(){} // RVA: 0x7ffaadfaf900
        public void ConvertAsyncStateMachineMethod(){} // RVA: 0x7ffaadfb0650
        public void ToString(){} // RVA: 0x7ffaadfb0aa0
        public void ToString(){} // RVA: 0x7ffaadfb0aa0
        // ── Binary Analysis Named ──
        public void GetFrame(){} // RVA: 0x7ffaadfaf620
        public void GetFrames(){} // RVA: 0x7ffaadfaf690
        public void GetAotId(){} // RVA: 0x7ffaadfaf850
        public void GetFullNameForStackTrace(){} // RVA: 0x7ffaadfafeb0
    }

    public class Stopwatch : Object
    {
        public object elapsed; // 0x351962D0

        // ── Original Methods ──
        public void StartNew(){} // RVA: 0x7ffaaede9bf0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void get_Elapsed(){} // RVA: 0x7ffaaede9c90
        public void get_ElapsedMilliseconds(){} // RVA: 0x7ffaaede9da0
        public void get_ElapsedTicks(){} // RVA: 0x7ffaaede9ef0
        public void get_IsRunning(){} // RVA: 0x7ffaa8a209d0
        public void Reset(){} // RVA: 0x7ffaaede9f60
        public void Start(){} // RVA: 0x7ffaaede9f70
        public void Stop(){} // RVA: 0x7ffaaede9fd0
        public void Restart(){} // RVA: 0x7ffaaedea050
        public void .cctor(){} // RVA: 0x7ffaaedea0b0
        // ── Binary Analysis Named ──
        public void GetTimestamp(){} // RVA: 0x7ffaae0f8fd0
    }

    public class SynchronizedList`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void AddIfNotExist(){} // RVA: 0x7ffaa887e5c0
        public void Remove(){} // RVA: 0x7ffaa887e5c0
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void EnumWithAction(){} // RVA: 0x7ffaa8669e70
    }

}