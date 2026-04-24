// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks
// Classes: 3
// Methods: 31

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks
{
    public class PlayerLoopHelper : Object
    {
        public object mainThreadId; // 0x3345C980
        public object yielders; // 0x3345C980

        // ── Original Methods ──
        public void get_UnitySynchronizationContext(){} // RVA: 0x7ffaaeea27e0
        public void get_MainThreadId(){} // RVA: 0x7ffaaeea2840
        public void get_ApplicationDataPath(){} // RVA: 0x7ffaaeea28a0
        public void get_IsMainThread(){} // RVA: 0x7ffaaeea2900
        public void get_IsEditorApplicationQuitting(){} // RVA: 0x7ffaaeea29c0
        public void set_IsEditorApplicationQuitting(){} // RVA: 0x7ffaaeea2a20
        public void InsertRunner(){} // RVA: 0x7ffaaeea2a80
        public void RemoveRunner(){} // RVA: 0x7ffaaeea2fe0
        public void InsertUniTaskSynchronizationContext(){} // RVA: 0x7ffaaeea3200
        public void Init(){} // RVA: 0x7ffaaeea38f0
        public void FindLoopSystemIndex(){} // RVA: 0x7ffaaeea3bf0
        public void InsertLoop(){} // RVA: 0x7ffaaeea3d00
        public void Initialize(){} // RVA: 0x7ffaaeea4150
        public void AddAction(){} // RVA: 0x7ffaaeea5d10
        public void ThrowInvalidLoopTiming(){} // RVA: 0x7ffaaeea5db0
        public void AddContinuation(){} // RVA: 0x7ffaaeea5e50
        public void DumpCurrentPlayerLoop(){} // RVA: 0x7ffaaeea5ef0
        public void IsInjectedUniTaskPlayerLoop(){} // RVA: 0x7ffaaeea6380
        public void .cctor(){} // RVA: 0x7ffaaeea6540
    }

    public class PlayerLoopTimer : Object
    {
        public object state; // 0x337257E0
        public object isRunning; // 0x337257E0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaeea6a10
        public void Create(){} // RVA: 0x7ffaaeea6b20
        public void StartNew(){} // RVA: 0x7ffaaeea6cb0
        public void Restart(){} // RVA: 0x7ffaaeea6eb0
        public void Restart(){} // RVA: 0x7ffaaeea6eb0
        public void Stop(){} // RVA: 0x7ffaaeea6fb0
        public void ResetCore(){}
        public void Dispose(){} // RVA: 0x7ffaaeea6fc0
        public void Cysharp.Threading.Tasks.IPlayerLoopItem.MoveNext(){} // RVA: 0x7ffaaeea6fd0
        public void MoveNextCore(){} // RVA: 0x7ffaa864a040
    }

    public class Progress : Object
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaa86492c0
        public void CreateOnlyValueChanged(){} // RVA: 0x7ffaa8649330
    }

}