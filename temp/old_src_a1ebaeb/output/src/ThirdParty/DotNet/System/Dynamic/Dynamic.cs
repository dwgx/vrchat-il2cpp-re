// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Dynamic
// Classes: 4
// Methods: 54

namespace ThirdParty.DotNet.System.Dynamic
{
    public class DynamicMetaObject : Object
    {
        public object _value; // 0x30B31FC0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae81a070
        public void .ctor(){} // RVA: 0x7ffaae81a070
        public void get_Expression(){} // RVA: 0x7ffaa89357c0
        public void get_Restrictions(){} // RVA: 0x7ffaa89600c0
        public void get_Value(){} // RVA: 0x7ffaae81a0e0
        public void get_HasValue(){} // RVA: 0x7ffaae81a160
        public void get_RuntimeType(){} // RVA: 0x7ffaae81a1d0
        public void get_LimitType(){} // RVA: 0x7ffaae81a2c0
        public void BindConvert(){} // RVA: 0x7ffaae81a3c0
        public void BindGetMember(){} // RVA: 0x7ffaae81a470
        public void BindSetMember(){} // RVA: 0x7ffaae81a520
        public void BindDeleteMember(){} // RVA: 0x7ffaae81a5f0
        public void BindGetIndex(){} // RVA: 0x7ffaae81a6a0
        public void BindSetIndex(){} // RVA: 0x7ffaae81a770
        public void BindDeleteIndex(){} // RVA: 0x7ffaae81a850
        public void BindInvokeMember(){} // RVA: 0x7ffaae81a920
        public void BindInvoke(){} // RVA: 0x7ffaae81a9f0
        public void BindCreateInstance(){} // RVA: 0x7ffaae81aac0
        public void BindUnaryOperation(){} // RVA: 0x7ffaae81ab90
        public void BindBinaryOperation(){} // RVA: 0x7ffaae81ac40
        public void Create(){} // RVA: 0x7ffaae81af40
        public void .cctor(){} // RVA: 0x7ffaae81b0f0
        // ── Binary Analysis Named ──
        public void GetDynamicMemberNames(){} // RVA: 0x7ffaae81ad10
        public void GetExpressions(){} // RVA: 0x7ffaae81ad50
    }

    public class DynamicMetaObjectBinder : CallSiteBinder
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae81b240
        public void get_ReturnType(){} // RVA: 0x7ffaae81b290
        public void Bind(){} // RVA: 0x7ffaa865aa30
        public void CreateArgumentMetaObjects(){} // RVA: 0x7ffaae81bb20
        public void Bind(){} // RVA: 0x7ffaa865aa30
        public void get_IsStandardBinder(){} // RVA: 0x7ffaa8932320
        // ── Binary Analysis Named ──
        public void GetUpdateExpression(){} // RVA: 0x7ffaae81bd30
    }

    public class DynamicObject : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void TryGetMember(){} // RVA: 0x7ffaae81be40
        public void TrySetMember(){} // RVA: 0x7ffaa8932320
        public void TryDeleteMember(){} // RVA: 0x7ffaa8932320
        public void TryInvokeMember(){} // RVA: 0x7ffaab211350
        public void TryConvert(){} // RVA: 0x7ffaae81be40
        public void TryCreateInstance(){} // RVA: 0x7ffaab211350
        public void TryInvoke(){} // RVA: 0x7ffaab211350
        public void TryBinaryOperation(){} // RVA: 0x7ffaab211350
        public void TryUnaryOperation(){} // RVA: 0x7ffaae81be40
        public void TryGetIndex(){} // RVA: 0x7ffaab211350
        public void TrySetIndex(){} // RVA: 0x7ffaa8932320
        public void TryDeleteIndex(){} // RVA: 0x7ffaa8932320
        // ── Binary Analysis Named ──
        public void GetDynamicMemberNames(){} // RVA: 0x7ffaae81bea0
        public void GetMetaObject(){} // RVA: 0x7ffaae81bee0
    }

    public class GetMemberBinder : DynamicMetaObjectBinder
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae826c50
        public void get_ReturnType(){} // RVA: 0x7ffaae826d80
        public void get_Name(){} // RVA: 0x7ffaa89357c0
        public void get_IgnoreCase(){} // RVA: 0x7ffaa8a209d0
        public void FallbackGetMember(){} // RVA: 0x7ffaa865aa30
        public void FallbackGetMember(){} // RVA: 0x7ffaa865aa30
        public void Bind(){} // RVA: 0x7ffaae826e30
        public void get_IsStandardBinder(){} // RVA: 0x7ffaa8a17850
    }

}