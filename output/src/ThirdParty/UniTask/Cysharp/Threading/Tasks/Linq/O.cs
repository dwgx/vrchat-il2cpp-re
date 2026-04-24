// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
// Classes: 5
// Methods: 14

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Linq
{
    public class OfType`1 : Object
    {
        public eObjectDelegate.fo<object> source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void GetAsyncEnumerator(){}
    }

    public class OrderedAsyncEnumerableAwaitWithCancellation`2 : OrderedAsyncEnumerable`1
    {
        public nalInformation<T1717635600,sageKind.TICMAP_SIZE,eObjectDelegate.kingField<T1717635616>> keySelector;
        public URA.ndar_data<T1717635616> comparer;
        public bool descending;
        public dLighting.t<T1717635600> parent;

        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerableSorter(){}
    }

    public class OrderedAsyncEnumerableAwait`2 : OrderedAsyncEnumerable`1
    {
        public n<T1717635568,eObjectDelegate.kingField<T1717635584>> keySelector;
        public URA.ndar_data<T1717635584> comparer;
        public bool descending;
        public dLighting.t<T1717635568> parent;

        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerableSorter(){}
    }

    public class OrderedAsyncEnumerable`1 : Object
    {
        public eObjectDelegate.fo<T1717635536> source; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void CreateOrderedEnumerable(){} // overloaded x3
        public void GetAsyncEnumerableSorter(){}
        public void GetAsyncEnumerator(){}
    }

    public class OrderedAsyncEnumerable`2 : OrderedAsyncEnumerable`1
    {
        public n<T1717635536,T1717635552> keySelector;
        public URA.ndar_data<T1717635552> comparer;
        public bool descending;
        public dLighting.t<T1717635536> parent;

        // ── Methods ──
        public void .ctor(){}
        public void GetAsyncEnumerableSorter(){}
    }

}