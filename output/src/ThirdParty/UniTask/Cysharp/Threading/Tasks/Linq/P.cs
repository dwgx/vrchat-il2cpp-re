// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
// Classes: 2
// Methods: 6

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
{
    public class Pairwise`1 : Object
    {
        public eObjectDelegate.fo<T1717635648> source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void GetAsyncEnumerator(){}
    }

    public class Publish`1 : Object
    {
        public eObjectDelegate.fo<T1717635712> source;
        public sageKind._internal cancellationTokenSource;
        public eObjectDelegate.roperty<T1717635712> trigger;
        public eObjectDelegate.o<T1717635712> enumerator;
        public Names connectedDisposable;
        public bool isCompleted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void Connect(){} // RVA: 0x7FFD4E078E90
        public void ConsumeEnumerator(){} // RVA: 0x7FFD4E079D00
        public void GetAsyncEnumerator(){}
    }

}