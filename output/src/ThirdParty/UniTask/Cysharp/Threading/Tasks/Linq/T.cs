// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
// Classes: 23
// Methods: 52

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
{
    public class TakeLast`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public int count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C77970
        public void GetAsyncEnumerator(){}
    }

    public class TakeUntilCanceled`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Threading.CancellationToken cancellationToken;

        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerator(){}
    }

    public class TakeUntil`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public Cysharp.Threading.Tasks.UniTask other;
        public System.Func`2<System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask> other2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void GetAsyncEnumerator(){}
    }

    public class TakeWhileAwaitWithCancellation`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`3<T,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void GetAsyncEnumerator(){}
    }

    public class TakeWhileAwait`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`2<T,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void GetAsyncEnumerator(){}
    }

    public class TakeWhileIntAwaitWithCancellation`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`4<T,int,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void GetAsyncEnumerator(){}
    }

    public class TakeWhileIntAwait`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`3<T,int,Cysharp.Threading.Tasks.UniTask`1<bool>> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void GetAsyncEnumerator(){}
    }

    public class TakeWhileInt`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`3<T,int,bool> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void GetAsyncEnumerator(){}
    }

    public class TakeWhile`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public System.Func`2<T,bool> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void GetAsyncEnumerator(){}
    }

    public class Take`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;
        public int count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C77970
        public void GetAsyncEnumerator(){}
    }

    public class Throw`1 : Object
    {
        public System.Exception exception;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void GetAsyncEnumerator(){}
    }

    public class Timer : Object
    {
        public 0x6B1DD918 updateTiming; // 0x10
        public System.TimeSpan dueTime; // 0x18
        public System.Nullable`1<System.TimeSpan> period; // 0x20
        public bool ignoreTimeScale; // 0x30
        public bool cancelImmediately; // 0x31

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC94C39E0
        public void GetAsyncEnumerator(){} // RVA: 0x7FFAC94C3A10
    }

    public class TimerFrame : Object
    {
        public 0x6B1DD918 updateTiming; // 0x10
        public int dueTimeFrameCount; // 0x14
        public System.Nullable`1<int> periodFrameCount; // 0x18
        public bool cancelImmediately; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC94C43C0
        public void GetAsyncEnumerator(){} // RVA: 0x7FFAC94C43E0
    }

    public class ToArray : Object
    {
        // ── Methods ──
        public void ToArrayAsync(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ToDictionary : Object
    {
        // ── Methods ──
        public void ToDictionaryAsync(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ToDictionaryAwaitAsync(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ToDictionaryAwaitWithCancellationAsync(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    }

    public class ToHashSet : Object
    {
        // ── Methods ──
        public void ToHashSetAsync(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ToList : Object
    {
        // ── Methods ──
        public void ToListAsync(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ToLookup : Object
    {
        // ── Methods ──
        public void ToLookupAsync(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ToLookupAwaitAsync(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ToLookupAwaitWithCancellationAsync(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    }

    public class ToObservable`1 : Object
    {
        public Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable`1<T> source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void Subscribe(){} // RVA: 0x7FFAC2C58F40
        public void RunAsync(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ToUniTaskAsyncEnumerableObservable`1 : Object
    {
        public System.IObservable`1<T> source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void GetAsyncEnumerator(){}
    }

    public class ToUniTaskAsyncEnumerableTask`1 : Object
    {
        public System.Threading.Tasks.Task`1<T> source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void GetAsyncEnumerator(){}
    }

    public class ToUniTaskAsyncEnumerableUniTask`1 : Object
    {
        public Cysharp.Threading.Tasks.UniTask`1<T> source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void GetAsyncEnumerator(){}
    }

    public class ToUniTaskAsyncEnumerable`1 : Object
    {
        public System.Collections.Generic.IEnumerable`1<T> source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void GetAsyncEnumerator(){}
    }

}