// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Compiler
// Classes: 3
// Methods: 18

namespace ThirdParty.DotNet.System.Linq.Expressions.Compiler
{
    public class DelegateHelpers : Object
    {
        public TypeInfo _DelegateCache;
        public int MaximumArity;

        // ── Methods ──
        public void MakeDelegateType(){} // RVA: 0x7FFAC8DF1EF0
        public void NextTypeInfo(){} // RVA: 0x7FFAC8DF25E0 | overloaded x2
        public void GetNextTypeInfo(){} // RVA: 0x7FFAC8DF2410
        public void TryMakeVBStyledCallSite(){} // RVA: 0x7FFAC8DF2790
        public void MakeNewDelegate(){} // RVA: 0x7FFAC8DF2ED0
        public void GetFuncType(){} // RVA: 0x7FFAC8DF30B0
        public void GetActionType(){} // RVA: 0x7FFAC8DF3390
        public void MakeCallSiteDelegate(){} // RVA: 0x7FFAC8DF3690
        public void MakeDeferredSiteDelegate(){} // RVA: 0x7FFAC8DF3AA0
        public void IsByRef(){} // RVA: 0x7FFAC8DF41E0
        public void MakeNewCustomDelegate(){} // RVA: 0x7FFAC8DF4280
        public void .cctor(){} // RVA: 0x7FFAC8DF42C0
    }

    public class HoistedLocals : Object
    {
        public System.Linq.Expressions.Compiler.HoistedLocals ParentVariable; // 0x10
        public System.Collections.ObjectModel.ReadOnlyDictionary`2<System.Linq.Expressions.Expression,int> Indexes; // 0x18
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression> Variables; // 0x20
        public System.Linq.Expressions.ParameterExpression SelfVariable; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DF4370
        public void get_ParentVariable(){} // RVA: 0x7FFAC8DF48D0
        public void GetParent(){} // RVA: 0x7FFAC8DF48E0
    }

    public class TypeInfoExtensions : Object
    {
        // ── Methods ──
        public void MakeDelegateType(){} // RVA: 0x7FFAC8DF4980 | overloaded x2
    }

}