// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks
// Classes: 3
// Methods: 31

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks
{
    public class PlayerLoopHelper
    {
        public object Parser;
        public object Descriptor;
        public object pb::Google.Protobuf.IMessage.Descriptor;
        public object GeometryPipelineOptions;

        // ── Methods ──
        public void get_UnitySynchronizationContext(){} // RVA: 0x7FFAF97980B0
        public void get_MainThreadId(){} // RVA: 0x7FFAF9798110
        public void get_ApplicationDataPath(){} // RVA: 0x7FFAF9798170
        public void get_IsMainThread(){} // RVA: 0x7FFAF97981D0
        public void get_IsEditorApplicationQuitting(){} // RVA: 0x7FFAF9798290
        public void set_IsEditorApplicationQuitting(){} // RVA: 0x7FFAF97982F0
        public void InsertRunner(){} // RVA: 0x7FFAF9798350
        public void RemoveRunner(){} // RVA: 0x7FFAF97988B0
        public void InsertUniTaskSynchronizationContext(){} // RVA: 0x7FFAF9798AD0
        public void Init(){} // RVA: 0x7FFAF97991C0
        public void FindLoopSystemIndex(){} // RVA: 0x7FFAF97994C0
        public void InsertLoop(){} // RVA: 0x7FFAF97995D0
        public void Initialize(){} // RVA: 0x7FFAF9799A20
        public void AddAction(){} // RVA: 0x7FFAF979B5E0
        public void ThrowInvalidLoopTiming(){} // RVA: 0x7FFAF979B680
        public void AddContinuation(){} // RVA: 0x7FFAF979B720
        public void DumpCurrentPlayerLoop(){} // RVA: 0x7FFAF979B7C0
        public void IsInjectedUniTaskPlayerLoop(){} // RVA: 0x7FFAF979BC50
        public void .cctor(){} // RVA: 0x7FFAF979BE10
    }

    public class PlayerLoopTimer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF979C2E0
        public void Create(){} // RVA: 0x7FFAF979C3F0
        public void StartNew(){} // RVA: 0x7FFAF979C580
        public void Restart(){} // RVA: 0x7FFAF979C780 | overloaded x2
        public void Stop(){} // RVA: 0x7FFAF979C880
        public void ResetCore(){}
        public void Dispose(){} // RVA: 0x7FFAF979C890
        public void Cysharp.Threading.Tasks.IPlayerLoopItem.MoveNext(){} // RVA: 0x7FFAF979C8A0
        public void MoveNextCore(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class Progress
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF2ABCE50
        public void CreateOnlyValueChanged(){} // RVA: 0x7FFAF2ABCEC0
    }

}