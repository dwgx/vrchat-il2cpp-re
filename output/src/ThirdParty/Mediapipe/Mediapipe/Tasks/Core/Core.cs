// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Core
// Classes: 5
// Methods: 27

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Core
{
    public class BaseOptions : Object
    {
        // ── Methods ──
        public void get_delegateCase(){} // RVA: 0x7A8124910
        public void get_modelAssetPath(){} // RVA: 0x7A80DA7B0
        public void get_modelAssetBuffer(){} // RVA: 0x7A81052C0
        public void .ctor(){} // RVA: 0x7AD968FD0
        public void get_acceleration(){} // RVA: 0x7AD969130
        public void get_modelAsset(){} // RVA: 0x7AD9692C0
        public void ToProto(){} // RVA: 0x7AD969380
        public void <delegateCase>k__BackingField(){} // RVA: 0x7B3F86E88
    }

    public class ITaskOptions
    {
        // ── Methods ──
        public void ToCalculatorOptions(){} // RVA: 0x7A7E00680
    }

    public class PacketsCallbackTable : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AD9696C0
        public void TryGetValue(){} // RVA: 0x7AD969950
        public void InvokeCallbackIfFound(){} // RVA: 0x7AD9699F0
        public void .cctor(){} // RVA: 0x7AD969BE0
        public void _Counter(){} // RVA: 0x7B41F3B08
    }

    public class TaskInfo`1 : Object
    {
        // ── Methods ──
        public void get_taskGraph(){} // RVA: 0x7A7E00680
        public void get_inputStreams(){} // RVA: 0x7A7E00680
        public void get_outputStreams(){} // RVA: 0x7A7E00680
        public void get_taskOptions(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A8051B10
        public void GenerateGraphConfig(){} // RVA: 0x7A7E063A0
        public void AddStreamNamePrefix(){} // RVA: 0x7A7E00BA0
    }

    public class TaskRunner : MpResourceHandle
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AD969CD0
        public void .ctor(){} // RVA: 0x7ABBD1620
        public void DeleteMpPtr(){} // RVA: 0x7AD969E50
        public void Process(){} // RVA: 0x7AD969F10
        public void Send(){} // RVA: 0x7AD96A090
        public void Close(){} // RVA: 0x7AD96A1E0
    }

}