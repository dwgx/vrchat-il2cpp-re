// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks
// Classes: 3
// Methods: 30

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks
{
    public class PlayerLoopHelper : Object
    {
        // ── Methods ──
        public void get_UnitySynchronizationContext(){} // RVA: 0x77468E0
        public void get_MainThreadId(){} // RVA: 0x7746940
        public void get_ApplicationDataPath(){} // RVA: 0x77469A0
        public void get_IsMainThread(){} // RVA: 0x7746A00
        public void get_IsEditorApplicationQuitting(){} // RVA: 0x7746AC0
        public void set_IsEditorApplicationQuitting(){} // RVA: 0x7746B20
        public void InsertRunner(){} // RVA: 0x7746B80
        public void RemoveRunner(){} // RVA: 0x77470E0
        public void InsertUniTaskSynchronizationContext(){} // RVA: 0x7747300
        public void Init(){} // RVA: 0x77479C0
        public void FindLoopSystemIndex(){} // RVA: 0x7747CB0
        public void InsertLoop(){} // RVA: 0x7747DB0
        public void Initialize(){} // RVA: 0x7748200
        public void AddAction(){} // RVA: 0x77496E0
        public void ThrowInvalidLoopTiming(){} // RVA: 0x7749780
        public void AddContinuation(){} // RVA: 0x7749820
        public void DumpCurrentPlayerLoop(){} // RVA: 0x77498C0
        public void IsInjectedUniTaskPlayerLoop(){} // RVA: 0x7749D20
        public void .cctor(){} // RVA: 0x7749EF0
    }

    public class PlayerLoopTimer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x774A370
        public void Create(){} // RVA: 0x774A480
        public void StartNew(){} // RVA: 0x774A610
        public void Restart(){} // RVA: 0x774A810
        public void Stop(){} // RVA: 0x774A910
        public void ResetCore(){} // RVA: 0x894320
        public void Dispose(){} // RVA: 0x774A920
        public void Cysharp.Threading.Tasks.IPlayerLoopItem.MoveNext(){} // RVA: 0x774A930
        public void MoveNextCore(){} // RVA: 0x87D280
    }

    public class Progress : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x87C5C0
        public void CreateOnlyValueChanged(){} // RVA: 0x87C630
    }

}