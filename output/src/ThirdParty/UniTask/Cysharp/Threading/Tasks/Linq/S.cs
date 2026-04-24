// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
// Classes: 24
// Methods: 96

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
{
    public class SelectAwaitWithCancellation`2 : Object
    {
        public eObjectDelegate.fo<T1717636192> source;
        public nalInformation<T1717636192,sageKind.TICMAP_SIZE,eObjectDelegate.kingField<T1717636208>> selector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SelectAwait`2 : Object
    {
        public eObjectDelegate.fo<T1717636064> source;
        public n<T1717636064,eObjectDelegate.kingField<T1717636080>> selector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SelectIntAwaitWithCancellation`2 : Object
    {
        public eObjectDelegate.fo<T1717636256> source;
        public rmation<T1717636256,int,sageKind.TICMAP_SIZE,eObjectDelegate.kingField<T1717636272>> selector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SelectIntAwait`2 : Object
    {
        public eObjectDelegate.fo<T1717636128> source;
        public nalInformation<T1717636128,int,eObjectDelegate.kingField<T1717636144>> selector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SelectInt`2 : Object
    {
        public eObjectDelegate.fo<T1717636000> source;
        public nalInformation<T1717636000,int,T1717636016> selector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SelectManyAwaitWithCancellation`3 : Object
    {
        public eObjectDelegate.fo<T1717636672> source;
        public nalInformation<T1717636672,sageKind.TICMAP_SIZE,eObjectDelegate.kingField<eObjectDelegate.fo<T1717636688>>> selector1;
        public rmation<T1717636672,int,sageKind.TICMAP_SIZE,eObjectDelegate.kingField<eObjectDelegate.fo<T1717636688>>> selector2;
        public rmation<T1717636672,T1717636688,sageKind.TICMAP_SIZE,eObjectDelegate.kingField<T1717636704>> resultSelector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09AF60 | overloaded x2
        public void GetAsyncEnumerator(){}
    }

    public class SelectManyAwait`3 : Object
    {
        public eObjectDelegate.fo<T1717636528> source;
        public n<T1717636528,eObjectDelegate.kingField<eObjectDelegate.fo<T1717636544>>> selector1;
        public nalInformation<T1717636528,int,eObjectDelegate.kingField<eObjectDelegate.fo<T1717636544>>> selector2;
        public nalInformation<T1717636528,T1717636544,eObjectDelegate.kingField<T1717636560>> resultSelector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09AF60 | overloaded x2
        public void GetAsyncEnumerator(){}
    }

    public class SelectMany`3 : Object
    {
        public eObjectDelegate.fo<T1717636384> source;
        public n<T1717636384,eObjectDelegate.fo<T1717636400>> selector1;
        public nalInformation<T1717636384,int,eObjectDelegate.fo<T1717636400>> selector2;
        public nalInformation<T1717636384,T1717636400,T1717636416> resultSelector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09AF60 | overloaded x2
        public void GetAsyncEnumerator(){}
    }

    public class Select`2 : Object
    {
        public eObjectDelegate.fo<T1717635936> source;
        public n<T1717635936,T1717635952> selector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SequenceEqual : Object
    {
        // ── Methods ──
        public void SequenceEqualAsync(){} // RVA: 0x7FFD4E2ADC40
    }

    public class SingleOperator : Object
    {
        // ── Methods ──
        public void SingleAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void SingleAwaitAsync(){} // RVA: 0x7FFD4E2ADC40
        public void SingleAwaitWithCancellationAsync(){} // RVA: 0x7FFD4E2ADC40
    }

    public class SkipLast`1 : Object
    {
        public eObjectDelegate.fo<T1717636928> source;
        public int count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E097970
        public void GetAsyncEnumerator(){}
    }

    public class SkipUntilCanceled`1 : Object
    {
        public eObjectDelegate.fo<T1717637008> source;
        public sageKind.TICMAP_SIZE cancellationToken;

        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerator(){}
    }

    public class SkipUntil`1 : Object
    {
        public eObjectDelegate.fo<T1717636976> source;
        public eObjectDelegate.eNonPublicAccessors other;
        public n<sageKind.TICMAP_SIZE,eObjectDelegate.eNonPublicAccessors> other2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void GetAsyncEnumerator(){}
    }

    public class SkipWhileAwaitWithCancellation`1 : Object
    {
        public eObjectDelegate.fo<T1717637168> source;
        public nalInformation<T1717637168,sageKind.TICMAP_SIZE,eObjectDelegate.kingField<bool>> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SkipWhileAwait`1 : Object
    {
        public eObjectDelegate.fo<T1717637104> source;
        public n<T1717637104,eObjectDelegate.kingField<bool>> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SkipWhileIntAwaitWithCancellation`1 : Object
    {
        public eObjectDelegate.fo<T1717637200> source;
        public rmation<T1717637200,int,sageKind.TICMAP_SIZE,eObjectDelegate.kingField<bool>> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SkipWhileIntAwait`1 : Object
    {
        public eObjectDelegate.fo<T1717637136> source;
        public nalInformation<T1717637136,int,eObjectDelegate.kingField<bool>> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SkipWhileInt`1 : Object
    {
        public eObjectDelegate.fo<T1717637072> source;
        public nalInformation<T1717637072,int,bool> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class SkipWhile`1 : Object
    {
        public eObjectDelegate.fo<T1717637040> source;
        public n<T1717637040,bool> predicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void GetAsyncEnumerator(){}
    }

    public class Skip`1 : Object
    {
        public eObjectDelegate.fo<T1717636896> source;
        public int count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E097970
        public void GetAsyncEnumerator(){}
    }

    public class Subscribe : Object
    {
        public ileFullDirectoryInformation<ÏÏÍÍÎÎ> NopError;
        public ÎÌÍÏÏÌÍÏ NopCompleted; // 0x8

        // ── Methods ──
        public void SubscribeCore(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void SubscribeAwaitCore(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD548DC390
    }

    public class Sum : Object
    {
        // ── Methods ──
        public void SumAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x20
        public void SumAwaitAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x10
        public void SumAwaitWithCancellationAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x10
    }

    public class SyncSelectorAsyncEnumerableSorter`2 : AsyncEnumerableSorter`1
    {
        public n<T1717635280,T1717635296> keySelector;
        public URA.ndar_data<T1717635296> comparer;
        public bool descending;
        public dLighting.rsalMode<T1717635280> next;
        public T1717635296[] keys;

        // ── Methods ──
        public void .ctor(){}
        public void ComputeKeysAsync(){}
        public void CompareKeys(){} // RVA: 0x7FFD4E080290
    }

}