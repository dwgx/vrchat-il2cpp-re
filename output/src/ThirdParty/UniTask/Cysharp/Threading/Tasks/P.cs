// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks
// Classes: 3
// Methods: 30

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks
{
    public class PlayerLoopHelper : Object
    {
        // ── Methods ──
        public void get_UnitySynchronizationContext(){} // RVA: 0x7AEAD6FC0
        public void get_MainThreadId(){} // RVA: 0x7AEAD7020
        public void get_ApplicationDataPath(){} // RVA: 0x7AEAD7080
        public void get_IsMainThread(){} // RVA: 0x7AEAD70E0
        public void get_IsEditorApplicationQuitting(){} // RVA: 0x7AEAD71A0
        public void set_IsEditorApplicationQuitting(){} // RVA: 0x7AEAD7200
        public void InsertRunner(){} // RVA: 0x7AEAD7260
        public void RemoveRunner(){} // RVA: 0x7AEAD77C0
        public void InsertUniTaskSynchronizationContext(){} // RVA: 0x7AEAD79E0
        public void Init(){} // RVA: 0x7AEAD80D0
        public void FindLoopSystemIndex(){} // RVA: 0x7AEAD8400
        public void InsertLoop(){} // RVA: 0x7AEAD8520
        public void Initialize(){} // RVA: 0x7AEAD8970
        public void AddAction(){} // RVA: 0x7AEADA530
        public void ThrowInvalidLoopTiming(){} // RVA: 0x7AEADA5D0
        public void AddContinuation(){} // RVA: 0x7AEADA670
        public void DumpCurrentPlayerLoop(){} // RVA: 0x7AEADA710
        public void IsInjectedUniTaskPlayerLoop(){} // RVA: 0x7AEADAB70
        public void .cctor(){} // RVA: 0x7AEADAD50
    }

    public class PlayerLoopTimer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEADB220
        public void Create(){} // RVA: 0x7AEADB330
        public void StartNew(){} // RVA: 0x7AEADB4C0
        public void Restart(){} // RVA: 0x7AEADB6C0
        public void Stop(){} // RVA: 0x7AEADB7C0
        public void ResetCore(){} // RVA: 0x7A7E18800
        public void Dispose(){} // RVA: 0x7AEADB7D0
        public void Cysharp.Threading.Tasks.IPlayerLoopItem.MoveNext(){} // RVA: 0x7AEADB7E0
        public void MoveNextCore(){} // RVA: 0x7A7E01900
    }

    public class Progress : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7A7E00BA0
        public void CreateOnlyValueChanged(){} // RVA: 0x7A7E00C10
    }

}