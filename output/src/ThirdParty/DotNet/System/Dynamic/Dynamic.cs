// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Dynamic
// Classes: 4
// Methods: 54

namespace ThirdParty.DotNet.System.Dynamic
{
    public class DynamicMetaObject : Object
    {
        public System.Dynamic.DynamicMetaObject[] Expression;
        public object Restrictions; // 0x8
        public object Value; // 0x10
        public System.Linq.Expressions.Expression HasValue; // 0x18
        public 0x66557178 RuntimeType; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD542180F0 | overloaded x2
        public void get_Expression(){} // RVA: 0x7FFD4E3447C0
        public void get_Restrictions(){} // RVA: 0x7FFD4E36F0C0
        public void get_Value(){} // RVA: 0x7FFD54218160
        public void get_HasValue(){} // RVA: 0x7FFD542181E0
        public void get_RuntimeType(){} // RVA: 0x7FFD54218250
        public void get_LimitType(){} // RVA: 0x7FFD54218340
        public void BindConvert(){} // RVA: 0x7FFD54218440
        public void BindGetMember(){} // RVA: 0x7FFD542184F0
        public void BindSetMember(){} // RVA: 0x7FFD542185A0
        public void BindDeleteMember(){} // RVA: 0x7FFD54218670
        public void BindGetIndex(){} // RVA: 0x7FFD54218720
        public void BindSetIndex(){} // RVA: 0x7FFD542187F0
        public void BindDeleteIndex(){} // RVA: 0x7FFD542188D0
        public void BindInvokeMember(){} // RVA: 0x7FFD542189A0
        public void BindInvoke(){} // RVA: 0x7FFD54218A70
        public void BindCreateInstance(){} // RVA: 0x7FFD54218B40
        public void BindUnaryOperation(){} // RVA: 0x7FFD54218C10
        public void BindBinaryOperation(){} // RVA: 0x7FFD54218CC0
        public void GetDynamicMemberNames(){} // RVA: 0x7FFD54218D90
        public void GetExpressions(){} // RVA: 0x7FFD54218DD0
        public void Create(){} // RVA: 0x7FFD54218FC0
        public void .cctor(){} // RVA: 0x7FFD54219170
    }

    public class DynamicMetaObjectBinder : CallSiteBinder
    {
        public object ReturnType;
        public object IsStandardBinder;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD542192C0
        public void get_ReturnType(){} // RVA: 0x7FFD54219310
        public void Bind(){} // RVA: 0x7FFD4E08A6F0 | overloaded x2
        public void CreateArgumentMetaObjects(){} // RVA: 0x7FFD54219BA0
        public void GetUpdateExpression(){} // RVA: 0x7FFD54219DB0
        public void get_IsStandardBinder(){} // RVA: 0x7FFD4E341320
    }

    public class DynamicObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void TryGetMember(){} // RVA: 0x7FFD54219EC0
        public void TrySetMember(){} // RVA: 0x7FFD4E341320
        public void TryDeleteMember(){} // RVA: 0x7FFD4E341320
        public void TryInvokeMember(){} // RVA: 0x7FFD50C274C0
        public void TryConvert(){} // RVA: 0x7FFD54219EC0
        public void TryCreateInstance(){} // RVA: 0x7FFD50C274C0
        public void TryInvoke(){} // RVA: 0x7FFD50C274C0
        public void TryBinaryOperation(){} // RVA: 0x7FFD50C274C0
        public void TryUnaryOperation(){} // RVA: 0x7FFD54219EC0
        public void TryGetIndex(){} // RVA: 0x7FFD50C274C0
        public void TrySetIndex(){} // RVA: 0x7FFD4E341320
        public void TryDeleteIndex(){} // RVA: 0x7FFD4E341320
        public void GetDynamicMemberNames(){} // RVA: 0x7FFD54219F20
        public void GetMetaObject(){} // RVA: 0x7FFD54219F60
    }

    public class GetMemberBinder : DynamicMetaObjectBinder
    {
        public string ReturnType; // 0x18
        public bool Name; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54224CD0
        public void get_ReturnType(){} // RVA: 0x7FFD54224E00
        public void get_Name(){} // RVA: 0x7FFD4E3447C0
        public void get_IgnoreCase(){} // RVA: 0x7FFD4E42F9D0
        public void FallbackGetMember(){} // RVA: 0x7FFD4E08A6F0 | overloaded x2
        public void Bind(){} // RVA: 0x7FFD54224EB0
        public void get_IsStandardBinder(){} // RVA: 0x7FFD4E426850
    }

}