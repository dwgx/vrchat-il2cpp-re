// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Core
// Classes: 5
// Methods: 25

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Core
{
    public class BaseOptions
    {
        public 0x65933B48 <delegateCase>k__BackingField; // 0x10
        public string <modelAssetPath>k__BackingField; // 0x18
        public byte[] <modelAssetBuffer>k__BackingField; // 0x20

        // ── Methods ──
        public void get_delegateCase(){} // RVA: 0x32A5C0
        public void get_modelAssetPath(){} // RVA: 0x2E07C0
        public void get_modelAssetBuffer(){} // RVA: 0x30B0C0
        public void .ctor(){} // RVA: 0x5B7B220
        public void get_acceleration(){} // RVA: 0x5B7B380
        public void get_modelAsset(){} // RVA: 0x5B7B510
        public void ToProto(){} // RVA: 0x5B7B5D0
    }

    public class ITaskOptions
    {
        // ── Methods ──
        public void ToCalculatorOptions(){} // RVA: 0xCD60
    }

    public class PacketsCallbackTable
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x5B7B910
        public void TryGetValue(){} // RVA: 0x5B7BBB0
        public void InvokeCallbackIfFound(){} // RVA: 0x5B7BC50
        public void .cctor(){} // RVA: 0x5B7BE40
    }

    public class TaskInfo`1
    {
        public string Size;
        public System.Collections.Generic.List`1<string> <inputStreams>k__BackingField;
        public System.Collections.Generic.List`1<string> <outputStreams>k__BackingField;
        public T <taskOptions>k__BackingField;

        // ── Methods ──
        public void get_taskGraph(){} // RVA: 0xCD60
        public void get_inputStreams(){} // RVA: 0xCD60
        public void get_outputStreams(){} // RVA: 0xCD60
        public void get_taskOptions(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x283FA0
        public void GenerateGraphConfig(){}
        public void AddStreamNamePrefix(){} // RVA: 0xCE50
    }

    public class TaskRunner
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x5B7BF30
        public void .ctor(){} // RVA: 0x3DD6EA0
        public void DeleteMpPtr(){} // RVA: 0x5B7C0B0
        public void Process(){} // RVA: 0x5B7C170
        public void Send(){} // RVA: 0x5B7C2F0
        public void Close(){} // RVA: 0x5B7C440
    }

}