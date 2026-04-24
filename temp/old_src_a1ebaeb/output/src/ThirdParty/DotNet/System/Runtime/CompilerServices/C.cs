// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.CompilerServices
// Classes: 42
// Methods: 202

namespace ThirdParty.DotNet.System.Runtime.CompilerServices
{
    public class CallSite : Object
    {
        public object _match; // 0x30B31A70
        public object Binder; // 0x1700038D

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void get_Binder(){} // RVA: 0x7ffaa894d380
        public void Create(){} // RVA: 0x7ffaae8170f0
    }

    public class CallSiteBinder : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void get_UpdateLabel(){} // RVA: 0x7ffaae8177b0
        public void Bind(){} // RVA: 0x7ffaa865b1c0
        public void BindDelegate(){} // RVA: 0x7ffaa887e5c0
        public void BindCore(){} // RVA: 0x7ffaa887e5c0
        public void CacheTarget(){} // RVA: 0x7ffaa887e5c0
        public void Stitch(){} // RVA: 0x7ffaa8649330
        public void .cctor(){} // RVA: 0x7ffaae817810
        // ── Binary Analysis Named ──
        public void GetRuleCache(){} // RVA: 0x7ffaa86491d0
    }

    public class CallSiteOps : Object
    {
        // ── Original Methods ──
        public void CreateMatchmaker(){} // RVA: 0x7ffaa86492c0
        public void ClearMatch(){} // RVA: 0x7ffaae8179e0
        public void AddRule(){} // RVA: 0x7ffaa887e5c0
        public void UpdateRules(){} // RVA: 0x7ffaa86666b0
        public void MoveRule(){} // RVA: 0x7ffaa887e5c0
        public void Bind(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void SetNotMatched(){} // RVA: 0x7ffaae8179c0
        public void GetMatch(){} // RVA: 0x7ffaac0fbd00
        public void GetRules(){} // RVA: 0x7ffaa86492c0
        public void GetRuleCache(){} // RVA: 0x7ffaa86492c0
        public void GetCachedRules(){} // RVA: 0x7ffaa86492c0
    }

    public class CallSite`1 : CallSite
    {
        public object s_cachedUpdate; // 0x30B318F0
        public object  ; // 0x3024EA20

        // ── Original Methods ──
        public void get_Update(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void CreateMatchMaker(){} // RVA: 0x7ffaa86491d0
        public void Create(){} // RVA: 0x7ffaa86492c0
        public void AddRule(){} // RVA: 0x7ffaa887e5c0
        public void MoveRule(){} // RVA: 0x7ffaa8661210
        public void MakeUpdateDelegate(){} // RVA: 0x7ffaa887e5c0
        public void CreateCustomUpdateDelegate(){} // RVA: 0x7ffaa887e5c0
        public void CreateCustomNoMatchDelegate(){} // RVA: 0x7ffaa887e5c0
        public void Convert(){} // RVA: 0x7ffaa8649330
        // ── Binary Analysis Named ──
        public void GetUpdateDelegate(){} // RVA: 0x7ffaa887e5c0
        public void GetUpdateDelegate(){} // RVA: 0x7ffaa887e5c0
    }

    public class CompilationRelaxationsAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa89350c0
        public void .ctor(){} // RVA: 0x7ffaa89350c0
        public void get_CompilationRelaxations(){} // RVA: 0x7ffaa897f5c0
    }

    public class CompilerGeneratedAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object COMPACT_FACTOR; // 0x30B604D0
        public object _lock; // 0x30B604D0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void Finalize(){} // RVA: 0x7ffaa8660cc0
        public void RehashWithoutResize(){} // RVA: 0x7ffaa8660cc0
        public void RecomputeSize(){} // RVA: 0x7ffaa8660cc0
        public void Rehash(){} // RVA: 0x7ffaa8660cc0
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void Remove(){} // RVA: 0x7ffaa887e5c0
        public void TryGetValue(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        // ── Binary Analysis Named ──
        public void GetOrCreateValue(){} // RVA: 0x7ffaa887e5c0
        public void GetValue(){} // RVA: 0x7ffaa887e5c0
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object COMPACT_FACTOR; // 0x356ED1A8
        public object _lock; // 0x356ED1A8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae7f7d0
        public void Finalize(){} // RVA: 0x7ffaaae7f920
        public void RehashWithoutResize(){} // RVA: 0x7ffaaae7f960
        public void RecomputeSize(){} // RVA: 0x7ffaaae7fc10
        public void Rehash(){} // RVA: 0x7ffaaae7fc70
        public void Add(){} // RVA: 0x7ffaaae80020
        public void Remove(){} // RVA: 0x7ffaaae804c0
        public void TryGetValue(){} // RVA: 0x7ffaaae808c0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7ffaaae810b0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae812e0
        // ── Binary Analysis Named ──
        public void GetOrCreateValue(){} // RVA: 0x7ffaaae80c60
        public void GetValue(){} // RVA: 0x7ffaaae80e60
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object COMPACT_FACTOR; // 0x357D12A0
        public object _lock; // 0x357D12A0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae7f7d0
        public void Finalize(){} // RVA: 0x7ffaaae7f920
        public void RehashWithoutResize(){} // RVA: 0x7ffaaae7f960
        public void RecomputeSize(){} // RVA: 0x7ffaaae7fc10
        public void Rehash(){} // RVA: 0x7ffaaae7fc70
        public void Add(){} // RVA: 0x7ffaaae80020
        public void Remove(){} // RVA: 0x7ffaaae804c0
        public void TryGetValue(){} // RVA: 0x7ffaaae808c0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7ffaaae810b0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae812e0
        // ── Binary Analysis Named ──
        public void GetOrCreateValue(){} // RVA: 0x7ffaaae80c60
        public void GetValue(){} // RVA: 0x7ffaaae80e60
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object COMPACT_FACTOR; // 0x35D69A48
        public object _lock; // 0x35D69A48
        public object `Ǐf; // 0x1D0000

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae7f7d0
        public void Finalize(){} // RVA: 0x7ffaaae7f920
        public void RehashWithoutResize(){} // RVA: 0x7ffaaae7f960
        public void RecomputeSize(){} // RVA: 0x7ffaaae7fc10
        public void Rehash(){} // RVA: 0x7ffaaae7fc70
        public void Add(){} // RVA: 0x7ffaaae80020
        public void Remove(){} // RVA: 0x7ffaaae804c0
        public void TryGetValue(){} // RVA: 0x7ffaaae808c0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7ffaaae810b0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae812e0
        // ── Binary Analysis Named ──
        public void GetOrCreateValue(){} // RVA: 0x7ffaaae80c60
        public void GetValue(){} // RVA: 0x7ffaaae80e60
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object COMPACT_FACTOR; // 0x35F8E000
        public object _lock; // 0x35F8E000

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae7f7d0
        public void Finalize(){} // RVA: 0x7ffaaae7f920
        public void RehashWithoutResize(){} // RVA: 0x7ffaaae7f960
        public void RecomputeSize(){} // RVA: 0x7ffaaae7fc10
        public void Rehash(){} // RVA: 0x7ffaaae7fc70
        public void Add(){} // RVA: 0x7ffaaae80020
        public void Remove(){} // RVA: 0x7ffaaae804c0
        public void TryGetValue(){} // RVA: 0x7ffaaae808c0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7ffaaae810b0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae812e0
        // ── Binary Analysis Named ──
        public void GetOrCreateValue(){} // RVA: 0x7ffaaae80c60
        public void GetValue(){} // RVA: 0x7ffaaae80e60
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object COMPACT_FACTOR; // 0x3683DA70
        public object _lock; // 0x3683DA70

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae7f7d0
        public void Finalize(){} // RVA: 0x7ffaaae7f920
        public void RehashWithoutResize(){} // RVA: 0x7ffaaae7f960
        public void RecomputeSize(){} // RVA: 0x7ffaaae7fc10
        public void Rehash(){} // RVA: 0x7ffaaae7fc70
        public void Add(){} // RVA: 0x7ffaaae80020
        public void Remove(){} // RVA: 0x7ffaaae804c0
        public void TryGetValue(){} // RVA: 0x7ffaaae808c0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7ffaaae810b0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae812e0
        // ── Binary Analysis Named ──
        public void GetOrCreateValue(){} // RVA: 0x7ffaaae80c60
        public void GetValue(){} // RVA: 0x7ffaaae80e60
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object COMPACT_FACTOR; // 0x36A2F8A0
        public object _lock; // 0x36A2F8A0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae7f7d0
        public void Finalize(){} // RVA: 0x7ffaaae7f920
        public void RehashWithoutResize(){} // RVA: 0x7ffaaae7f960
        public void RecomputeSize(){} // RVA: 0x7ffaaae7fc10
        public void Rehash(){} // RVA: 0x7ffaaae7fc70
        public void Add(){} // RVA: 0x7ffaaae80020
        public void Remove(){} // RVA: 0x7ffaaae804c0
        public void TryGetValue(){} // RVA: 0x7ffaaae808c0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7ffaaae810b0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae812e0
        // ── Binary Analysis Named ──
        public void GetOrCreateValue(){} // RVA: 0x7ffaaae80c60
        public void GetValue(){} // RVA: 0x7ffaaae80e60
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object COMPACT_FACTOR; // 0x37C9B648
        public object _lock; // 0x37C9B648

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae7f7d0
        public void Finalize(){} // RVA: 0x7ffaaae7f920
        public void RehashWithoutResize(){} // RVA: 0x7ffaaae7f960
        public void RecomputeSize(){} // RVA: 0x7ffaaae7fc10
        public void Rehash(){} // RVA: 0x7ffaaae7fc70
        public void Add(){} // RVA: 0x7ffaaae80020
        public void Remove(){} // RVA: 0x7ffaaae804c0
        public void TryGetValue(){} // RVA: 0x7ffaaae808c0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7ffaaae810b0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae812e0
        // ── Binary Analysis Named ──
        public void GetOrCreateValue(){} // RVA: 0x7ffaaae80c60
        public void GetValue(){} // RVA: 0x7ffaaae80e60
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object COMPACT_FACTOR; // 0x37CAABF8
        public object _lock; // 0x37CAABF8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae7f7d0
        public void Finalize(){} // RVA: 0x7ffaaae7f920
        public void RehashWithoutResize(){} // RVA: 0x7ffaaae7f960
        public void RecomputeSize(){} // RVA: 0x7ffaaae7fc10
        public void Rehash(){} // RVA: 0x7ffaaae7fc70
        public void Add(){} // RVA: 0x7ffaaae80020
        public void Remove(){} // RVA: 0x7ffaaae804c0
        public void TryGetValue(){} // RVA: 0x7ffaaae808c0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7ffaaae810b0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae812e0
        // ── Binary Analysis Named ──
        public void GetOrCreateValue(){} // RVA: 0x7ffaaae80c60
        public void GetValue(){} // RVA: 0x7ffaaae80e60
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object COMPACT_FACTOR; // 0x37F78220
        public object _lock; // 0x37F78220

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae7f7d0
        public void Finalize(){} // RVA: 0x7ffaaae7f920
        public void RehashWithoutResize(){} // RVA: 0x7ffaaae7f960
        public void RecomputeSize(){} // RVA: 0x7ffaaae7fc10
        public void Rehash(){} // RVA: 0x7ffaaae7fc70
        public void Add(){} // RVA: 0x7ffaaae80020
        public void Remove(){} // RVA: 0x7ffaaae804c0
        public void TryGetValue(){} // RVA: 0x7ffaaae808c0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7ffaaae810b0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae812e0
        // ── Binary Analysis Named ──
        public void GetOrCreateValue(){} // RVA: 0x7ffaaae80c60
        public void GetValue(){} // RVA: 0x7ffaaae80e60
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object COMPACT_FACTOR; // 0x39CBDB30
        public object _lock; // 0x39CBDB30

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae7f7d0
        public void Finalize(){} // RVA: 0x7ffaaae7f920
        public void RehashWithoutResize(){} // RVA: 0x7ffaaae7f960
        public void RecomputeSize(){} // RVA: 0x7ffaaae7fc10
        public void Rehash(){} // RVA: 0x7ffaaae7fc70
        public void Add(){} // RVA: 0x7ffaaae80020
        public void Remove(){} // RVA: 0x7ffaaae804c0
        public void TryGetValue(){} // RVA: 0x7ffaaae808c0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7ffaaae810b0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae812e0
        // ── Binary Analysis Named ──
        public void GetOrCreateValue(){} // RVA: 0x7ffaaae80c60
        public void GetValue(){} // RVA: 0x7ffaaae80e60
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object COMPACT_FACTOR; // 0x39CC4558
        public object _lock; // 0x39CC4558

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae7f7d0
        public void Finalize(){} // RVA: 0x7ffaaae7f920
        public void RehashWithoutResize(){} // RVA: 0x7ffaaae7f960
        public void RecomputeSize(){} // RVA: 0x7ffaaae7fc10
        public void Rehash(){} // RVA: 0x7ffaaae7fc70
        public void Add(){} // RVA: 0x7ffaaae80020
        public void Remove(){} // RVA: 0x7ffaaae804c0
        public void TryGetValue(){} // RVA: 0x7ffaaae808c0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7ffaaae810b0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae812e0
        // ── Binary Analysis Named ──
        public void GetOrCreateValue(){} // RVA: 0x7ffaaae80c60
        public void GetValue(){} // RVA: 0x7ffaaae80e60
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8666840
        // ── Binary Analysis Named ──
        public void GetAwaiter(){} // RVA: 0x7ffaa887e5c0
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae93880
        // ── Binary Analysis Named ──
        public void GetAwaiter(){} // RVA: 0x7ffaa8ce3e60
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae93880
        // ── Binary Analysis Named ──
        public void GetAwaiter(){} // RVA: 0x7ffaa8ce3e60
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae93880
        // ── Binary Analysis Named ──
        public void GetAwaiter(){} // RVA: 0x7ffaa8ce3e60
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae93880
        // ── Binary Analysis Named ──
        public void GetAwaiter(){} // RVA: 0x7ffaa8ce3e60
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae93880
        // ── Binary Analysis Named ──
        public void GetAwaiter(){} // RVA: 0x7ffaa8ce3e60
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
    }

    public class ConfiguredValueTaskAwaitable`1 : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetAwaiter(){} // RVA: 0x7ffaa887e5c0
    }

    public class ConfiguredValueTaskAwaitable`1 : ValueType
    {
        public object !00; // 0x854B13C8
    }

    public class ConfiguredValueTaskAwaitable`1 : ValueType
    {
    }

    public class ConfiguredValueTaskAwaitable`1 : ValueType
    {
    }

    public class ConfiguredValueTaskAwaitable`1 : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa4a3e50
        // ── Binary Analysis Named ──
        public void GetAwaiter(){} // RVA: 0x7ffaaae96210
    }

    public class CustomConstantAttribute : Attribute
    {
        // ── Original Methods ──
        public void get_Value(){} // RVA: 0x7ffaa86491d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

}