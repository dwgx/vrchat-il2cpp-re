// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
// Classes: 22
// Methods: 50

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
{
    public class TakeLast`1 : Object
    {
        public eObjectDelegate.fo<T1717638416> source;
        public int count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E097970
        public void GetAsyncEnumerator(){}
    }

    public class TakeUntilCanceled`1 : Object
    {
        public eObjectDelegate.fo<T1717638496> source;
        public sageKind.TICMAP_SIZE cancellationToken;

        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerator(){}
    }

    public class TakeUntil`1 : Object
    {
        public eObjectDelegate.fo<T1717638464> source;
        public eObjectDelegate.eNonPublicAccessors other;
        public n<sageKind.TICMAP_SIZE,eObjectDelegate.eNonPublicAccessors> other2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void GetAsyncEnumerator(){}
    }

    public class TakeWhileAwaitWithCancellation`1 : Object
    {
        public eObjectDelegate.fo<T1717638656> source;
        public nalInformation<T1717638656,sageKind.TICMAP_SIZE,eObjectDelegate.kingField<bool>> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class TakeWhileAwait`1 : Object
    {
        public eObjectDelegate.fo<T1717638592> source;
        public n<T1717638592,eObjectDelegate.kingField<bool>> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class TakeWhileIntAwaitWithCancellation`1 : Object
    {
        public eObjectDelegate.fo<T1717638688> source;
        public rmation<T1717638688,int,sageKind.TICMAP_SIZE,eObjectDelegate.kingField<bool>> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class TakeWhileIntAwait`1 : Object
    {
        public eObjectDelegate.fo<T1717638624> source;
        public nalInformation<T1717638624,int,eObjectDelegate.kingField<bool>> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class TakeWhileInt`1 : Object
    {
        public eObjectDelegate.fo<T1717638560> source;
        public nalInformation<T1717638560,int,bool> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class TakeWhile`1 : Object
    {
        public eObjectDelegate.fo<T1717638528> source;
        public n<T1717638528,bool> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class Take`1 : Object
    {
        public eObjectDelegate.fo<T1717638384> source;
        public int count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E097970
        public void GetAsyncEnumerator(){}
    }

    public class Throw`1 : Object
    {
        public ÏÏÍÍÎÎ exception;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void GetAsyncEnumerator(){}
    }

    public class Timer : Object
    {
        public eObjectDelegate.sonElementConverter updateTiming; // 0x10
        public ializable.GetObjectData dueTime; // 0x18
        public aphy<ializable.GetObjectData> period; // 0x20
        public bool ignoreTimeScale; // 0x30
        public bool cancelImmediately; // 0x31

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD548E39E0
        public void GetAsyncEnumerator(){} // RVA: 0x7FFD548E3A10
    }

    public class ToArray : Object
    {
        // ── Methods ──
        public void ToArrayAsync(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ToDictionary : Object
    {
        // ── Methods ──
        public void ToDictionaryAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ToDictionaryAwaitAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ToDictionaryAwaitWithCancellationAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    }

    public class ToHashSet : Object
    {
        // ── Methods ──
        public void ToHashSetAsync(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ToList : Object
    {
        // ── Methods ──
        public void ToListAsync(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ToLookup : Object
    {
        // ── Methods ──
        public void ToLookupAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ToLookupAwaitAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ToLookupAwaitWithCancellationAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    }

    public class ToObservable`1 : Object
    {
        public eObjectDelegate.fo<T1717640096> source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void Subscribe(){} // RVA: 0x7FFD4E078F40
        public void RunAsync(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ToUniTaskAsyncEnumerableObservable`1 : Object
    {
        public subkeyWritable<T1717640256> source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void GetAsyncEnumerator(){}
    }

    public class ToUniTaskAsyncEnumerableTask`1 : Object
    {
        public utes.?<T1717640176> source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void GetAsyncEnumerator(){}
    }

    public class ToUniTaskAsyncEnumerableUniTask`1 : Object
    {
        public eObjectDelegate.kingField<T1717640224> source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void GetAsyncEnumerator(){}
    }

    public class ToUniTaskAsyncEnumerable`1 : Object
    {
        public URA.bbrevEraNames<T1717640128> source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void GetAsyncEnumerator(){}
    }

}