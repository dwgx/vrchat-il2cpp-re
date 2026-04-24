// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
// Classes: 2
// Methods: 6

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
{
    public class Pairwise`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void GetAsyncEnumerator(){}
    }

    public class Publish`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Threading.CancellationTokenSource cancellationTokenSource;
        public Cysharp.Threading.Tasks.TriggerEvent`1<T> trigger;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<T> enumerator;
        public System.IDisposable connectedDisposable;
        public bool isCompleted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void Connect(){} // RVA: 0x7FFD4E078E90
        public void ConsumeEnumerator(){} // RVA: 0x7FFD4E079D00
        public void GetAsyncEnumerator(){}
    }

}