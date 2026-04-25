// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Core
// Classes: 5
// Methods: 25

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Core
{
    public class BaseOptions : Object
    {
        public 0x6B217990 delegateCase; // 0x10
        public string modelAssetPath; // 0x18
        public byte[] modelAssetBuffer; // 0x20

        // ── Methods ──
        public void get_delegateCase(){} // RVA: 0x7FFAC2F6E5C0
        public void get_modelAssetPath(){} // RVA: 0x7FFAC2F247C0
        public void get_modelAssetBuffer(){} // RVA: 0x7FFAC2F4F0C0
        public void .ctor(){} // RVA: 0x7FFAC8312750
        public void get_acceleration(){} // RVA: 0x7FFAC83128B0
        public void get_modelAsset(){} // RVA: 0x7FFAC8312A40
        public void ToProto(){} // RVA: 0x7FFAC8312B00
    }

    public class ITaskOptions
    {
        // ── Methods ──
        public void ToCalculatorOptions(){} // RVA: 0x7FFAC2C58E90
    }

    public class PacketsCallbackTable : Object
    {
        public int _Counter;
        public Mediapipe.GlobalInstanceTable`2<int,PacketsCallback> _Table; // 0x8

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC8312E40
        public void TryGetValue(){} // RVA: 0x7FFAC83130E0
        public void InvokeCallbackIfFound(){} // RVA: 0x7FFAC8313180
        public void .cctor(){} // RVA: 0x7FFAC8313370
    }

    public class TaskInfo`1 : Object
    {
        public string taskGraph;
        public System.Collections.Generic.List`1<string> inputStreams;
        public System.Collections.Generic.List`1<string> outputStreams;
        public T taskOptions;

        // ── Methods ──
        public void get_taskGraph(){} // RVA: 0x7FFAC2C58E90
        public void get_inputStreams(){} // RVA: 0x7FFAC2C58E90
        public void get_outputStreams(){} // RVA: 0x7FFAC2C58E90
        public void get_taskOptions(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void GenerateGraphConfig(){}
        public void AddStreamNamePrefix(){} // RVA: 0x7FFAC2C58F80
    }

    public class TaskRunner : MpResourceHandle
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC8313460
        public void .ctor(){} // RVA: 0x7FFAC66E2830
        public void DeleteMpPtr(){} // RVA: 0x7FFAC83135E0
        public void Process(){} // RVA: 0x7FFAC83136A0
        public void Send(){} // RVA: 0x7FFAC8313820
        public void Close(){} // RVA: 0x7FFAC8313970
    }

}