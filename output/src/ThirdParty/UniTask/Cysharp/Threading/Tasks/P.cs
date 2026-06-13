// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks
// Classes: 3
// Methods: 31

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks
{
    public class PlayerLoopHelper
    {
        public Cysharp.Threading.Tasks.Internal.ContinuationQueue Parser;
        public Cysharp.Threading.Tasks.Internal.PlayerLoopRunner Descriptor; // 0x8
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x10
        public string GeometryPipelineOptions; // 0x18
        public System.Threading.SynchronizationContext unitySynchronizationContext; // 0x20

        // ── Methods ──
        public void get_UnitySynchronizationContext(){} // RVA: 0x6CE80B0
        public void get_MainThreadId(){} // RVA: 0x6CE8110
        public void get_ApplicationDataPath(){} // RVA: 0x6CE8170
        public void get_IsMainThread(){} // RVA: 0x6CE81D0
        public void get_IsEditorApplicationQuitting(){} // RVA: 0x6CE8290
        public void set_IsEditorApplicationQuitting(){} // RVA: 0x6CE82F0
        public void InsertRunner(){} // RVA: 0x6CE8350
        public void RemoveRunner(){} // RVA: 0x6CE88B0
        public void InsertUniTaskSynchronizationContext(){} // RVA: 0x6CE8AD0
        public void Init(){} // RVA: 0x6CE91C0
        public void FindLoopSystemIndex(){} // RVA: 0x6CE94C0
        public void InsertLoop(){} // RVA: 0x6CE95D0
        public void Initialize(){} // RVA: 0x6CE9A20
        public void AddAction(){} // RVA: 0x6CEB5E0
        public void ThrowInvalidLoopTiming(){} // RVA: 0x6CEB680
        public void AddContinuation(){} // RVA: 0x6CEB720
        public void DumpCurrentPlayerLoop(){} // RVA: 0x6CEB7C0
        public void IsInjectedUniTaskPlayerLoop(){} // RVA: 0x6CEBC50
        public void .cctor(){} // RVA: 0x6CEBE10
    }

    public class PlayerLoopTimer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CEC2E0
        public void Create(){} // RVA: 0x6CEC3F0
        public void StartNew(){} // RVA: 0x6CEC580
        public void Restart(){} // RVA: 0x6CEC780 | overloaded x2
        public void Stop(){} // RVA: 0x6CEC880
        public void ResetCore(){}
        public void Dispose(){} // RVA: 0x6CEC890
        public void Cysharp.Threading.Tasks.IPlayerLoopItem.MoveNext(){} // RVA: 0x6CEC8A0
        public void MoveNextCore(){} // RVA: 0xDBE0
    }

    public class Progress
    {
        // ── Methods ──
        public void Create(){} // RVA: 0xCE50
        public void CreateOnlyValueChanged(){} // RVA: 0xCEC0
    }

}