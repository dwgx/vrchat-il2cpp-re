// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Core
// Classes: 5
// Methods: 25

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Core
{
    public class BaseOptions : Object
    {
        public object _modelAssetBuffer; // 0x337E7980, was: <modelAssetBuffer>k__BackingFi
        public object delegateCase; // 0x170002FD

        // ── Original Methods ──
        public void get_delegateCase(){} // RVA: 0x7ffaa897f5c0
        public void get_modelAssetPath(){} // RVA: 0x7ffaa89357c0
        public void get_modelAssetBuffer(){} // RVA: 0x7ffaa89600c0
        public void .ctor(){} // RVA: 0x7ffaadd33900
        public void get_acceleration(){} // RVA: 0x7ffaadd33a60
        public void get_modelAsset(){} // RVA: 0x7ffaadd33bf0
        public void ToProto(){} // RVA: 0x7ffaadd33cb0
    }

    public class ITaskOptions
    {
        // ── Original Methods ──
        public void ToCalculatorOptions(){} // RVA: 0x7ffaa86491d0
    }

    public class PacketsCallbackTable : Object
    {
        // ── Original Methods ──
        public void Add(){} // RVA: 0x7ffaadd33ff0
        public void TryGetValue(){} // RVA: 0x7ffaadd34290
        public void InvokeCallbackIfFound(){} // RVA: 0x7ffaadd34330
        public void .cctor(){} // RVA: 0x7ffaadd34520
    }

    public class TaskInfo`1 : Object
    {
        public object _outputStreams; // 0x313E9A10, was: <outputStreams>k__BackingField

        // ── Original Methods ──
        public void get_taskGraph(){} // RVA: 0x7ffaa86491d0
        public void get_inputStreams(){} // RVA: 0x7ffaa86491d0
        public void get_outputStreams(){} // RVA: 0x7ffaa86491d0
        public void get_taskOptions(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void GenerateGraphConfig(){}
        public void AddStreamNamePrefix(){} // RVA: 0x7ffaa86492c0
    }

    public class TaskRunner : MpResourceHandle
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaadd34610
        public void .ctor(){} // RVA: 0x7ffaac0f2690
        public void DeleteMpPtr(){} // RVA: 0x7ffaadd34790
        public void Process(){} // RVA: 0x7ffaadd34850
        public void Send(){} // RVA: 0x7ffaadd349d0
        public void Close(){} // RVA: 0x7ffaadd34b20
    }

}