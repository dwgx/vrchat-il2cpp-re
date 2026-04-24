// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics
// Classes: 9
// Methods: 75

namespace ThirdParty.DotNet.System.Diagnostics
{
    public class DebuggableAttribute : Attribute
    {
        public 0x6643C928 m_debuggingModes; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3440C0
    }

    public class Debugger : Object
    {
        public string IsAttached;

        // ── Methods ──
        public void get_IsAttached(){} // RVA: 0x7FFD539AD780
        public void IsAttached_internal(){} // RVA: 0x7FFD539AD7D0
        public void IsLogging(){} // RVA: 0x7FFD4E341320
        public void Log_icall(){} // RVA: 0x7FFD4E341310
        public void Log(){} // RVA: 0x7FFD539AD7F0
        public void NotifyOfCrossThreadDependency(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD539AD840
    }

    public class DiagEnumerator`1 : ValueType
    {
        public System.Diagnostics.DiagNode`1<T> Current;
        public System.Diagnostics.DiagNode`1<T> System.Collections.IEnumerator.Current;
        public System.Diagnostics.DiagNode`1<T> _currentNode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void get_Current(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
        public void MoveNext(){} // RVA: 0x7FFD4E079D00
        public void Reset(){} // RVA: 0x7FFD4E090980
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class DiagNode`1 : Object
    {
        public T Value;
        public System.Diagnostics.DiagNode`1<T> Next;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ExceptionExtensions : Object
    {
        public System.Reflection.FieldInfo stackTraceString;

        // ── Methods ──
        public void SetStackTracesString(){} // RVA: 0x7FFD5400A650
        public void Demystify(){} // RVA: 0x7FFD4E2ADC40
        public void ToStringDemystified(){} // RVA: 0x7FFD5400A6D0
        public void .cctor(){} // RVA: 0x7FFD5400A760
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
        public void get_frame_info(){} // RVA: 0x7FFD539AD8F0
        public void .ctor(){} // RVA: 0x7FFD539AD9B0 | overloaded x3
        public void GetFileLineNumber(){} // RVA: 0x7FFD4E9AA870
        public void GetFileColumnNumber(){} // RVA: 0x7FFD4E7DD4A0
        public void GetFileName(){} // RVA: 0x7FFD4E5F95E0
        public void GetSecureFileName(){} // RVA: 0x7FFD539ADA70
        public void GetILOffset(){} // RVA: 0x7FFD4E38E5C0
        public void GetMethod(){} // RVA: 0x7FFD4E36F130
        public void GetNativeOffset(){} // RVA: 0x7FFD4E7F5A20
        public void GetMethodAddress(){} // RVA: 0x7FFD4E3447C0
        public void GetMethodIndex(){} // RVA: 0x7FFD4E4FBBE0
        public void GetInternalMethodName(){} // RVA: 0x7FFD4E3BE740
        public void ToString(){} // RVA: 0x7FFD539ADAE0
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
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x11
        public void init_frames(){} // RVA: 0x7FFD539ADD60
        public void get_trace(){} // RVA: 0x7FFD539AE000
        public void get_FrameCount(){} // RVA: 0x7FFD5152DBD0
        public void GetFrame(){} // RVA: 0x7FFD539AE3D0
        public void GetFrames(){} // RVA: 0x7FFD539AE440
        public void GetAotId(){} // RVA: 0x7FFD539AE600
        public void AddFrames(){} // RVA: 0x7FFD539AE6B0
        public void GetFullNameForStackTrace(){} // RVA: 0x7FFD539AEC60
        public void ConvertAsyncStateMachineMethod(){} // RVA: 0x7FFD539AF400
        public void ToString(){} // RVA: 0x7FFD539AF850 | overloaded x2
    }

    public class Stopwatch : Object
    {
        public long Elapsed;
        public bool ElapsedMilliseconds; // 0x8
        public long ElapsedTicks; // 0x10
        public long IsRunning; // 0x18
        public bool is_running; // 0x20

        // ── Methods ──
        public void GetTimestamp(){} // RVA: 0x7FFD53AF7DC0
        public void StartNew(){} // RVA: 0x7FFD547E7C20
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_Elapsed(){} // RVA: 0x7FFD547E7CC0
        public void get_ElapsedMilliseconds(){} // RVA: 0x7FFD547E7DD0
        public void get_ElapsedTicks(){} // RVA: 0x7FFD547E7F20
        public void get_IsRunning(){} // RVA: 0x7FFD4E42F9D0
        public void Reset(){} // RVA: 0x7FFD547E7F90
        public void Start(){} // RVA: 0x7FFD547E7FA0
        public void Stop(){} // RVA: 0x7FFD547E8000
        public void Restart(){} // RVA: 0x7FFD547E8080
        public void .cctor(){} // RVA: 0x7FFD547E80E0
    }

    public class SynchronizedList`1 : Object
    {
        public System.Collections.Generic.List`1<T> Count;
        public uint _version;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void AddIfNotExist(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void EnumWithAction(){} // RVA: 0x7FFD4E099B30
    }

}