// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Core
// Classes: 5
// Methods: 25

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Core
{
    public class BaseOptions : Object
    {
        public 0x66611254 _delegateCase; // 0x10
        public string _modelAssetPath; // 0x18
        public byte[] _modelAssetBuffer; // 0x20
        public object field_3; // 0x2FD
        public object field_4; // 0x2FE

        // ── Methods ──
        public void get_delegateCase(){} // RVA: 0x7FFE811485C0
        public void get_modelAssetPath(){} // RVA: 0x7FFE810FE7C0
        public void get_modelAssetBuffer(){} // RVA: 0x7FFE811290C0
        public void .ctor(){} // RVA: 0x7FFE866BC050
        public void get_acceleration(){} // RVA: 0x7FFE866BC1B0
        public void get_modelAsset(){} // RVA: 0x7FFE866BC340
        public void ToProto(){} // RVA: 0x7FFE866BC400
    }

    public class ITaskOptions
    {
        // ── Methods ──
        public void ToCalculatorOptions(){} // RVA: 0x7FFE80E2E2E0
    }

    public class PacketsCallbackTable : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE866BC740
        public void TryGetValue(){} // RVA: 0x7FFE866BC9E0
        public void InvokeCallbackIfFound(){} // RVA: 0x7FFE866BCA80
        public void .cctor(){} // RVA: 0x7FFE866BCC70
    }

    public class TaskInfo`1 : Object
    {
        public string _taskGraph;
        public System.Collections.Generic.List`1<string> _inputStreams;
        public System.Collections.Generic.List`1<string> _outputStreams;
        public T _taskOptions;

        // ── Methods ──
        public void get_taskGraph(){} // RVA: 0x7FFE80E2E2E0
        public void get_inputStreams(){} // RVA: 0x7FFE80E2E2E0
        public void get_outputStreams(){} // RVA: 0x7FFE80E2E2E0
        public void get_taskOptions(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void GenerateGraphConfig(){}
        public void AddStreamNamePrefix(){} // RVA: 0x7FFE80E2E3D0
    }

    public class TaskRunner : MpResourceHandle
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE866BCD60
        public void .ctor(){} // RVA: 0x7FFE84A47410
        public void DeleteMpPtr(){} // RVA: 0x7FFE866BCEE0
        public void Process(){} // RVA: 0x7FFE866BCFA0
        public void Send(){} // RVA: 0x7FFE866BD120
        public void Close(){} // RVA: 0x7FFE866BD270
    }

}