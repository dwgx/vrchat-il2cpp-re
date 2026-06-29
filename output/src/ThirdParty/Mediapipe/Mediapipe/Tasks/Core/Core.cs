// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Core
// Classes: 5
// Methods: 25

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Core
{
    public class BaseOptions : Object
    {
        // ── Methods ──
        public void get_delegateCase(){} // RVA: 0xB8F8F0
        public void get_modelAssetPath(){} // RVA: 0xB465B0
        public void get_modelAssetBuffer(){} // RVA: 0xB700F0
        public void .ctor(){} // RVA: 0x65F50C0
        public void get_acceleration(){} // RVA: 0x65F51F0
        public void get_modelAsset(){} // RVA: 0x65F5380
        public void ToProto(){} // RVA: 0x65F5440
    }

    public class ITaskOptions
    {
        // ── Methods ──
        public void ToCalculatorOptions(){} // RVA: 0x87C0A0
    }

    public class PacketsCallbackTable : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x65F5780
        public void TryGetValue(){} // RVA: 0x65F5A10
        public void InvokeCallbackIfFound(){} // RVA: 0x65F5AB0
        public void .cctor(){} // RVA: 0x65F5CA0
    }

    public class TaskInfo`1 : Object
    {
        // ── Methods ──
        public void get_taskGraph(){} // RVA: 0x87C0A0
        public void get_inputStreams(){} // RVA: 0x87C0A0
        public void get_outputStreams(){} // RVA: 0x87C0A0
        public void get_taskOptions(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0xA94080
        public void GenerateGraphConfig(){} // RVA: 0x881D20
        public void AddStreamNamePrefix(){} // RVA: 0x87C5C0
    }

    public class TaskRunner : MpResourceHandle
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x65F5D90
        public void .ctor(){} // RVA: 0x4843CD0
        public void DeleteMpPtr(){} // RVA: 0x65F5F10
        public void Process(){} // RVA: 0x65F5FD0
        public void Send(){} // RVA: 0x65F6150
        public void Close(){} // RVA: 0x65F62A0
    }

}