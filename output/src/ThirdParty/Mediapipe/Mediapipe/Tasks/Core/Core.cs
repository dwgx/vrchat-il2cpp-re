// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Core
// Classes: 5
// Methods: 25

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Core
{
    public class BaseOptions
    {
        // ── Methods ──
        public void get_delegateCase(){} // RVA: 0x7FFAF2DDA5C0
        public void get_modelAssetPath(){} // RVA: 0x7FFAF2D907C0
        public void get_modelAssetBuffer(){} // RVA: 0x7FFAF2DBB0C0
        public void .ctor(){} // RVA: 0x7FFAF862B220
        public void get_acceleration(){} // RVA: 0x7FFAF862B380
        public void get_modelAsset(){} // RVA: 0x7FFAF862B510
        public void ToProto(){} // RVA: 0x7FFAF862B5D0
    }

    public class ITaskOptions
    {
        // ── Methods ──
        public void ToCalculatorOptions(){} // RVA: 0x7FFAF2ABCD60
    }

    public class PacketsCallbackTable
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAF862B910
        public void TryGetValue(){} // RVA: 0x7FFAF862BBB0
        public void InvokeCallbackIfFound(){} // RVA: 0x7FFAF862BC50
        public void .cctor(){} // RVA: 0x7FFAF862BE40
    }

    public class TaskInfo`1
    {
        public object Size;

        // ── Methods ──
        public void get_taskGraph(){} // RVA: 0x7FFAF2ABCD60
        public void get_inputStreams(){} // RVA: 0x7FFAF2ABCD60
        public void get_outputStreams(){} // RVA: 0x7FFAF2ABCD60
        public void get_taskOptions(){} // RVA: 0x7FFAF2D33FA0
        public void .ctor(){} // RVA: 0x7FFAF2D33FA0
        public void GenerateGraphConfig(){}
        public void AddStreamNamePrefix(){} // RVA: 0x7FFAF2ABCE50
    }

    public class TaskRunner
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF862BF30
        public void .ctor(){} // RVA: 0x7FFAF6886EA0
        public void DeleteMpPtr(){} // RVA: 0x7FFAF862C0B0
        public void Process(){} // RVA: 0x7FFAF862C170
        public void Send(){} // RVA: 0x7FFAF862C2F0
        public void Close(){} // RVA: 0x7FFAF862C440
    }

}