// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.CompilerServices
// Classes: 76
// Methods: 301

namespace ThirdParty.DotNet.System.Runtime.CompilerServices
{
    public class CallSite : Object
    {
        public object s_siteCtors;
        public object _binder;
        public object _match;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Binder(){} // RVA: 0xB5DBF0
        public void Create(){} // RVA: 0x70C9890
    }

    public class CallSiteBinder : Object
    {
        public object Cache;
        public object _updateLabel;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_UpdateLabel(){} // RVA: 0x70C9F50
        public void Bind(){} // RVA: 0x882090
        public void BindDelegate(){} // RVA: 0xA94080
        public void BindCore(){} // RVA: 0xA94080
        public void CacheTarget(){} // RVA: 0xA94080
        public void Stitch(){} // RVA: 0x87C630
        public void GetRuleCache(){} // RVA: 0x87C0A0
        public void .cctor(){} // RVA: 0x70C9FB0
    }

    public class CallSiteOps : Object
    {
        // ── Methods ──
        public void CreateMatchmaker(){} // RVA: 0x87C5C0
        public void SetNotMatched(){} // RVA: 0x70CA120
        public void GetMatch(){} // RVA: 0x484E7A0
        public void ClearMatch(){} // RVA: 0x70CA140
        public void AddRule(){} // RVA: 0xA94080
        public void UpdateRules(){} // RVA: 0x89AB50
        public void GetRules(){} // RVA: 0x87C5C0
        public void GetRuleCache(){} // RVA: 0x87C5C0
        public void MoveRule(){} // RVA: 0xA94080
        public void GetCachedRules(){} // RVA: 0x87C5C0
        public void Bind(){} // RVA: 0xA94080
    }

    public class CallSite`1 : CallSite
    {
        public object Target;
        public object Rules;
        public object s_cachedUpdate;
        public object s_cachedNoMatch;

        // ── Methods ──
        public void get_Update(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894290
        public void CreateMatchMaker(){} // RVA: 0x87C0A0
        public void Create(){} // RVA: 0x87C5C0
        public void GetUpdateDelegate(){} // RVA: 0xA94080
        public void AddRule(){} // RVA: 0xA94080
        public void MoveRule(){} // RVA: 0x8944F0
        public void MakeUpdateDelegate(){} // RVA: 0xA94080
        public void CreateCustomUpdateDelegate(){} // RVA: 0xA94080
        public void CreateCustomNoMatchDelegate(){} // RVA: 0xA94080
        public void Convert(){} // RVA: 0x87C630
    }

    public class CallerArgumentExpressionAttribute : Attribute
    {
        public object _parameterName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_ParameterName(){} // RVA: 0xB5DBF0
    }

    public class CallerArgumentExpressionAttribute : Attribute
    {
        public object _parameterName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class CallerArgumentExpressionAttribute : Attribute
    {
        public object _parameterName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class CallerArgumentExpressionAttribute : Attribute
    {
        public object _parameterName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_ParameterName(){} // RVA: 0xB5DBF0
    }

    public class CallerArgumentExpressionAttribute : Attribute
    {
        public object _parameterName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class CallerArgumentExpressionAttribute : Attribute
    {
        public object _parameterName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class CallerArgumentExpressionAttribute : Attribute
    {
        public object _parameterName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class CallerFilePathAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CallerLineNumberAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CallerMemberNameAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CompilationRelaxationsAttribute : Attribute
    {
        public object m_relaxations;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_CompilationRelaxations(){} // RVA: 0xB8F8F0
    }

    public class CompilerFeatureRequiredAttribute : Attribute
    {
        public object _featureName;
        public object _isOptional;
        public object RefStructs;
        public object RequiredMembers;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_FeatureName(){} // RVA: 0xB5DBF0
        public void get_IsOptional(){} // RVA: 0xB5DD50
        public void set_IsOptional(){} // RVA: 0xB5DD60
    }

    public class CompilerFeatureRequiredAttribute : Attribute
    {
        public object _featureName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class CompilerFeatureRequiredAttribute : Attribute
    {
        public object _featureName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class CompilerFeatureRequiredAttribute : Attribute
    {
        public object _featureName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class CompilerGeneratedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object data;
        public object _lock;
        public object size;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x34AA4B0
        public void Finalize(){} // RVA: 0x34AA600
        public void RehashWithoutResize(){} // RVA: 0x34AA640
        public void RecomputeSize(){} // RVA: 0x34AA8F0
        public void Rehash(){} // RVA: 0x34AA960
        public void Add(){} // RVA: 0x34AAD60
        public void Remove(){} // RVA: 0x34AB1D0
        public void TryGetValue(){} // RVA: 0x34AB580
        public void GetOrCreateValue(){} // RVA: 0x34AB8C0
        public void GetValue(){} // RVA: 0x34ABAD0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x34ABCF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34ABEF0
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object data;
        public object _lock;
        public object size;

        // ── Methods ──
        public void Add(){} // RVA: 0x34AAD60
        public void .ctor(){} // RVA: 0x34AA4B0
        public void Finalize(){} // RVA: 0x34AA600
        public void RehashWithoutResize(){} // RVA: 0x34AA640
        public void RecomputeSize(){} // RVA: 0x34AA8F0
        public void Rehash(){} // RVA: 0x34AA960
        public void Remove(){} // RVA: 0x34AB1D0
        public void TryGetValue(){} // RVA: 0x34AB580
        public void GetOrCreateValue(){} // RVA: 0x34AB8C0
        public void GetValue(){} // RVA: 0x34ABAD0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x34ABCF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34ABEF0
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object data;
        public object _lock;
        public object size;

        // ── Methods ──
        public void Add(){} // RVA: 0x34AAD60
        public void .ctor(){} // RVA: 0x34AA4B0
        public void Finalize(){} // RVA: 0x34AA600
        public void RehashWithoutResize(){} // RVA: 0x34AA640
        public void RecomputeSize(){} // RVA: 0x34AA8F0
        public void Rehash(){} // RVA: 0x34AA960
        public void Remove(){} // RVA: 0x34AB1D0
        public void TryGetValue(){} // RVA: 0x34AB580
        public void GetOrCreateValue(){} // RVA: 0x34AB8C0
        public void GetValue(){} // RVA: 0x34ABAD0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x34ABCF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34ABEF0
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object data;
        public object _lock;
        public object size;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x34AA4B0
        public void Finalize(){} // RVA: 0x34AA600
        public void RehashWithoutResize(){} // RVA: 0x34AA640
        public void RecomputeSize(){} // RVA: 0x34AA8F0
        public void Rehash(){} // RVA: 0x34AA960
        public void Add(){} // RVA: 0x34AAD60
        public void Remove(){} // RVA: 0x34AB1D0
        public void TryGetValue(){} // RVA: 0x34AB580
        public void GetOrCreateValue(){} // RVA: 0x34AB8C0
        public void GetValue(){} // RVA: 0x34ABAD0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x34ABCF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34ABEF0
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object data;
        public object _lock;
        public object size;

        // ── Methods ──
        public void Add(){} // RVA: 0x34AAD60
        public void .ctor(){} // RVA: 0x34AA4B0
        public void Finalize(){} // RVA: 0x34AA600
        public void RehashWithoutResize(){} // RVA: 0x34AA640
        public void RecomputeSize(){} // RVA: 0x34AA8F0
        public void Rehash(){} // RVA: 0x34AA960
        public void Remove(){} // RVA: 0x34AB1D0
        public void TryGetValue(){} // RVA: 0x34AB580
        public void GetOrCreateValue(){} // RVA: 0x34AB8C0
        public void GetValue(){} // RVA: 0x34ABAD0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x34ABCF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34ABEF0
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object data;
        public object _lock;
        public object size;

        // ── Methods ──
        public void Add(){} // RVA: 0x34AAD60
        public void .ctor(){} // RVA: 0x34AA4B0
        public void Finalize(){} // RVA: 0x34AA600
        public void RehashWithoutResize(){} // RVA: 0x34AA640
        public void RecomputeSize(){} // RVA: 0x34AA8F0
        public void Rehash(){} // RVA: 0x34AA960
        public void Remove(){} // RVA: 0x34AB1D0
        public void TryGetValue(){} // RVA: 0x34AB580
        public void GetOrCreateValue(){} // RVA: 0x34AB8C0
        public void GetValue(){} // RVA: 0x34ABAD0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x34ABCF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34ABEF0
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object data;
        public object _lock;
        public object size;

        // ── Methods ──
        public void Add(){} // RVA: 0x34AAD60
        public void .ctor(){} // RVA: 0x34AA4B0
        public void Finalize(){} // RVA: 0x34AA600
        public void RehashWithoutResize(){} // RVA: 0x34AA640
        public void RecomputeSize(){} // RVA: 0x34AA8F0
        public void Rehash(){} // RVA: 0x34AA960
        public void Remove(){} // RVA: 0x34AB1D0
        public void TryGetValue(){} // RVA: 0x34AB580
        public void GetOrCreateValue(){} // RVA: 0x34AB8C0
        public void GetValue(){} // RVA: 0x34ABAD0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x34ABCF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34ABEF0
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object data;
        public object _lock;
        public object size;

        // ── Methods ──
        public void Add(){} // RVA: 0x34AAD60
        public void .ctor(){} // RVA: 0x34AA4B0
        public void Finalize(){} // RVA: 0x34AA600
        public void RehashWithoutResize(){} // RVA: 0x34AA640
        public void RecomputeSize(){} // RVA: 0x34AA8F0
        public void Rehash(){} // RVA: 0x34AA960
        public void Remove(){} // RVA: 0x34AB1D0
        public void TryGetValue(){} // RVA: 0x34AB580
        public void GetOrCreateValue(){} // RVA: 0x34AB8C0
        public void GetValue(){} // RVA: 0x34ABAD0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x34ABCF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34ABEF0
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object data;
        public object _lock;
        public object size;

        // ── Methods ──
        public void Add(){} // RVA: 0x34AAD60
        public void .ctor(){} // RVA: 0x34AA4B0
        public void Finalize(){} // RVA: 0x34AA600
        public void RehashWithoutResize(){} // RVA: 0x34AA640
        public void RecomputeSize(){} // RVA: 0x34AA8F0
        public void Rehash(){} // RVA: 0x34AA960
        public void Remove(){} // RVA: 0x34AB1D0
        public void TryGetValue(){} // RVA: 0x34AB580
        public void GetOrCreateValue(){} // RVA: 0x34AB8C0
        public void GetValue(){} // RVA: 0x34ABAD0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x34ABCF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34ABEF0
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object data;
        public object _lock;
        public object size;

        // ── Methods ──
        public void Add(){} // RVA: 0x34AAD60
        public void .ctor(){} // RVA: 0x34AA4B0
        public void Finalize(){} // RVA: 0x34AA600
        public void RehashWithoutResize(){} // RVA: 0x34AA640
        public void RecomputeSize(){} // RVA: 0x34AA8F0
        public void Rehash(){} // RVA: 0x34AA960
        public void Remove(){} // RVA: 0x34AB1D0
        public void TryGetValue(){} // RVA: 0x34AB580
        public void GetOrCreateValue(){} // RVA: 0x34AB8C0
        public void GetValue(){} // RVA: 0x34ABAD0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x34ABCF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34ABEF0
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object data;
        public object _lock;
        public object size;

        // ── Methods ──
        public void Add(){} // RVA: 0x34AAD60
        public void .ctor(){} // RVA: 0x34AA4B0
        public void Finalize(){} // RVA: 0x34AA600
        public void RehashWithoutResize(){} // RVA: 0x34AA640
        public void RecomputeSize(){} // RVA: 0x34AA8F0
        public void Rehash(){} // RVA: 0x34AA960
        public void Remove(){} // RVA: 0x34AB1D0
        public void TryGetValue(){} // RVA: 0x34AB580
        public void GetOrCreateValue(){} // RVA: 0x34AB8C0
        public void GetValue(){} // RVA: 0x34ABAD0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x34ABCF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34ABEF0
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object data;
        public object _lock;
        public object size;

        // ── Methods ──
        public void Add(){} // RVA: 0x34AAD60
        public void .ctor(){} // RVA: 0x34AA4B0
        public void Finalize(){} // RVA: 0x34AA600
        public void RehashWithoutResize(){} // RVA: 0x34AA640
        public void RecomputeSize(){} // RVA: 0x34AA8F0
        public void Rehash(){} // RVA: 0x34AA960
        public void Remove(){} // RVA: 0x34AB1D0
        public void TryGetValue(){} // RVA: 0x34AB580
        public void GetOrCreateValue(){} // RVA: 0x34AB8C0
        public void GetValue(){} // RVA: 0x34ABAD0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x34ABCF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34ABEF0
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object data;
        public object _lock;
        public object size;

        // ── Methods ──
        public void Add(){} // RVA: 0x34AAD60
        public void .ctor(){} // RVA: 0x34AA4B0
        public void Finalize(){} // RVA: 0x34AA600
        public void RehashWithoutResize(){} // RVA: 0x34AA640
        public void RecomputeSize(){} // RVA: 0x34AA8F0
        public void Rehash(){} // RVA: 0x34AA960
        public void Remove(){} // RVA: 0x34AB1D0
        public void TryGetValue(){} // RVA: 0x34AB580
        public void GetOrCreateValue(){} // RVA: 0x34AB8C0
        public void GetValue(){} // RVA: 0x34ABAD0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x34ABCF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34ABEF0
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object data;
        public object _lock;
        public object size;

        // ── Methods ──
        public void Add(){} // RVA: 0x34AAD60
        public void .ctor(){} // RVA: 0x34AA4B0
        public void Finalize(){} // RVA: 0x34AA600
        public void RehashWithoutResize(){} // RVA: 0x34AA640
        public void RecomputeSize(){} // RVA: 0x34AA8F0
        public void Rehash(){} // RVA: 0x34AA960
        public void Remove(){} // RVA: 0x34AB1D0
        public void TryGetValue(){} // RVA: 0x34AB580
        public void GetOrCreateValue(){} // RVA: 0x34AB8C0
        public void GetValue(){} // RVA: 0x34ABAD0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x34ABCF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34ABEF0
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object data;
        public object _lock;
        public object size;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void Finalize(){} // RVA: 0x894290
        public void RehashWithoutResize(){} // RVA: 0x894290
        public void RecomputeSize(){} // RVA: 0x894290
        public void Rehash(){} // RVA: 0x894290
        public void Add(){} // RVA: 0xA94080
        public void Remove(){} // RVA: 0xA94080
        public void TryGetValue(){} // RVA: 0xA94080
        public void GetOrCreateValue(){} // RVA: 0xA94080
        public void GetValue(){} // RVA: 0xA94080
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    }

    public class ConditionalWeakTable`2 : Object
    {
        public object data;
        public object _lock;
        public object size;

        // ── Methods ──
        public void Add(){} // RVA: 0x34AAD60
        public void .ctor(){} // RVA: 0x34AA4B0
        public void Finalize(){} // RVA: 0x34AA600
        public void RehashWithoutResize(){} // RVA: 0x34AA640
        public void RecomputeSize(){} // RVA: 0x34AA8F0
        public void Rehash(){} // RVA: 0x34AA960
        public void Remove(){} // RVA: 0x34AB1D0
        public void TryGetValue(){} // RVA: 0x34AB580
        public void GetOrCreateValue(){} // RVA: 0x34AB8C0
        public void GetValue(){} // RVA: 0x34ABAD0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x34ABCF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34ABEF0
    }

    public class ConfiguredAsyncDisposable : ValueType
    {
        public object _source;
        public object _continueOnCapturedContext;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A130
        public void DisposeAsync(){} // RVA: 0x8E7C10
    }

    public class ConfiguredTaskAwaitable : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8AF3B0
        public void GetAwaiter(){} // RVA: 0x7BF80
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x899250
        public void GetAwaiter(){} // RVA: 0xA94080
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
        public void GetAwaiter(){} // RVA: 0x7BF80
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
        public void GetAwaiter(){} // RVA: 0x7BF80
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x7BF80
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x7BF80
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x7BF80
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x7BF80
    }

    public class ConfiguredTaskAwaitable`1 : ValueType
    {
        public object m_configuredTaskAwaiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x212F90
    }

    public class ConfiguredValueTaskAwaitable : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xD3E60
        public void GetAwaiter(){} // RVA: 0x8AEF40
    }

    public class ConfiguredValueTaskAwaitable : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xD3E60
        public void GetAwaiter(){} // RVA: 0x8AEF40
    }

    public class ConfiguredValueTaskAwaitable`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void GetAwaiter(){} // RVA: 0xA94080
    }

    public class ConfiguredValueTaskAwaitable`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x216AC0
    }

    public class ConfiguredValueTaskAwaitable`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xD3E60
        public void GetAwaiter(){} // RVA: 0x218490
    }

    public class ConfiguredValueTaskAwaitable`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xD3E60
    }

    public class ConfiguredValueTaskAwaitable`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x11E4F0
    }

    public class CustomConstantAttribute : Attribute
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0xB43310
    }

}