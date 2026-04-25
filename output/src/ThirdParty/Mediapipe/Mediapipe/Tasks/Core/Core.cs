// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Core
// Classes: 5
// Methods: 25

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Core
{
    public class BaseOptions : Object
    {
        public 0x66577990 delegateCase; // 0x10
        public string modelAssetPath; // 0x18
        public byte[] modelAssetBuffer; // 0x20

        // ── Methods ──
        public void get_delegateCase(){} // RVA: 0x7FFD4E38E5C0
        public void get_modelAssetPath(){} // RVA: 0x7FFD4E3447C0
        public void get_modelAssetBuffer(){} // RVA: 0x7FFD4E36F0C0
        public void .ctor(){} // RVA: 0x7FFD53732750
        public void get_acceleration(){} // RVA: 0x7FFD537328B0
        public void get_modelAsset(){} // RVA: 0x7FFD53732A40
        public void ToProto(){} // RVA: 0x7FFD53732B00
    }

    public class ITaskOptions
    {
        // ── Methods ──
        public void ToCalculatorOptions(){} // RVA: 0x7FFD4E078E90
    }

    public class PacketsCallbackTable : Object
    {
        public int _Counter;
        public Mediapipe.GlobalInstanceTable`2<int,0x66577BA0> _Table; // 0x8

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD53732E40
        public void TryGetValue(){} // RVA: 0x7FFD537330E0
        public void InvokeCallbackIfFound(){} // RVA: 0x7FFD53733180
        public void .cctor(){} // RVA: 0x7FFD53733370
    }

    public class TaskInfo`1 : Object
    {
        public string taskGraph;
        public System.Collections.Generic.List`1<string> inputStreams;
        public System.Collections.Generic.List`1<string> outputStreams;
        public T taskOptions;

        // ── Methods ──
        public void get_taskGraph(){} // RVA: 0x7FFD4E078E90
        public void get_inputStreams(){} // RVA: 0x7FFD4E078E90
        public void get_outputStreams(){} // RVA: 0x7FFD4E078E90
        public void get_taskOptions(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void GenerateGraphConfig(){}
        public void AddStreamNamePrefix(){} // RVA: 0x7FFD4E078F80
    }

    public class TaskRunner : MpResourceHandle
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD53733460
        public void .ctor(){} // RVA: 0x7FFD51B02830
        public void DeleteMpPtr(){} // RVA: 0x7FFD537335E0
        public void Process(){} // RVA: 0x7FFD537336A0
        public void Send(){} // RVA: 0x7FFD53733820
        public void Close(){} // RVA: 0x7FFD53733970
    }

}