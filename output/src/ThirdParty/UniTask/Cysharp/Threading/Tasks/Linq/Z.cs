// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
// Classes: 3
// Methods: 6

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
{
    public class ZipAwaitWithCancellation`3 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> first;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<V> second;
        public System.Func`4<U,V,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<T>> resultSelector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09AF60
        public void GetAsyncEnumerator(){}
    }

    public class ZipAwait`3 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> first;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<V> second;
        public System.Func`3<U,V,Cysharp.Threading.Tasks.UniTask`1<T>> resultSelector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09AF60
        public void GetAsyncEnumerator(){}
    }

    public class Zip`3 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<U> first;
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<V> second;
        public System.Func`3<U,V,T> resultSelector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09AF60
        public void GetAsyncEnumerator(){}
    }

}