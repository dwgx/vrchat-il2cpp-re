// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Dynamic
// Classes: 19
// Methods: 150

namespace ThirdParty.DotNet.System.Dynamic
{
    public class BinaryOperationBinder : DynamicMetaObjectBinder
    {
        public 0x665E5D54 _operation; // 0x18

        // ── Methods ──
        public void get_Operation(){} // RVA: 0x7FFE813DB630
        public void FallbackBinaryOperation(){} // RVA: 0x7FFE80E403A0 | overloaded x2
        public void Bind(){} // RVA: 0x7FFE8719DEE0
    }

    public class BindingRestrictions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void GetExpression(){} // RVA: 0x7FFE80E2E2E0
        public void Merge(){} // RVA: 0x7FFE8719E080
        public void GetTypeRestriction(){} // RVA: 0x7FFE8719E4A0 | overloaded x2
        public void GetInstanceRestriction(){} // RVA: 0x7FFE8719E570
        public void ToExpression(){} // RVA: 0x7FFE811AFBC0
        public void .cctor(){} // RVA: 0x7FFE8719E710
    }

    public class ConvertBinder : DynamicMetaObjectBinder
    {
        public System.Type _type; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE810FE7C0
        public void FallbackConvert(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
        public void Bind(){} // RVA: 0x7FFE8719FF00
    }

    public class CreateInstanceBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void FallbackCreateInstance(){} // RVA: 0x7FFE80E403A0 | overloaded x2
        public void Bind(){} // RVA: 0x7FFE871A0000
    }

    public class DeleteIndexBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x7FFE871A00F0
        public void FallbackDeleteIndex(){} // RVA: 0x7FFE80E403A0 | overloaded x2
    }

    public class DeleteMemberBinder : DynamicMetaObjectBinder
    {
        public string _name; // 0x18
        public bool _ignoreCase; // 0x20

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void get_IgnoreCase(){} // RVA: 0x7FFE811E99D0
        public void FallbackDeleteMember(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
        public void Bind(){} // RVA: 0x7FFE871A01E0
    }

    public class DynamicMetaObject : Object
    {
        public System.Dynamic.DynamicMetaObject[] EmptyMetaObjects;
        public object s_noValueSentinel; // 0x8
        public object _value; // 0x10
        public System.Linq.Expressions.Expression _expression; // 0x18
        public System.Dynamic.BindingRestrictions _restrictions; // 0x20
        public object field_5; // 0x3A4

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871A0520 | overloaded x2
        public void get_Expression(){} // RVA: 0x7FFE810FE7C0
        public void get_Restrictions(){} // RVA: 0x7FFE811290C0
        public void get_Value(){} // RVA: 0x7FFE871A0590
        public void get_HasValue(){} // RVA: 0x7FFE871A0610
        public void get_RuntimeType(){} // RVA: 0x7FFE871A0680
        public void get_LimitType(){} // RVA: 0x7FFE871A0770
        public void BindConvert(){} // RVA: 0x7FFE871A0870
        public void BindGetMember(){} // RVA: 0x7FFE871A0920
        public void BindSetMember(){} // RVA: 0x7FFE871A09D0
        public void BindDeleteMember(){} // RVA: 0x7FFE871A0AA0
        public void BindGetIndex(){} // RVA: 0x7FFE871A0B50
        public void BindSetIndex(){} // RVA: 0x7FFE871A0C20
        public void BindDeleteIndex(){} // RVA: 0x7FFE871A0D00
        public void BindInvokeMember(){} // RVA: 0x7FFE871A0DD0
        public void BindInvoke(){} // RVA: 0x7FFE871A0EA0
        public void BindCreateInstance(){} // RVA: 0x7FFE871A0F70
        public void BindUnaryOperation(){} // RVA: 0x7FFE871A1040
        public void BindBinaryOperation(){} // RVA: 0x7FFE871A10F0
        public void GetDynamicMemberNames(){} // RVA: 0x7FFE871A11C0
        public void GetExpressions(){} // RVA: 0x7FFE871A1200
        public void Create(){} // RVA: 0x7FFE871A13F0
        public void .cctor(){} // RVA: 0x7FFE871A15A0
    }

    public class DynamicMetaObjectBinder : CallSiteBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871A16F0
        public void get_ReturnType(){} // RVA: 0x7FFE871A1740
        public void Bind(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
        public void CreateArgumentMetaObjects(){} // RVA: 0x7FFE871A1FD0
        public void GetUpdateExpression(){} // RVA: 0x7FFE871A21E0
        public void get_IsStandardBinder(){} // RVA: 0x7FFE810FB320
    }

    public class DynamicObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void TryGetMember(){} // RVA: 0x7FFE871A22F0
        public void TrySetMember(){} // RVA: 0x7FFE810FB320
        public void TryDeleteMember(){} // RVA: 0x7FFE810FB320
        public void TryInvokeMember(){} // RVA: 0x7FFE83B23650
        public void TryConvert(){} // RVA: 0x7FFE871A22F0
        public void TryCreateInstance(){} // RVA: 0x7FFE83B23650
        public void TryInvoke(){} // RVA: 0x7FFE83B23650
        public void TryBinaryOperation(){} // RVA: 0x7FFE83B23650
        public void TryUnaryOperation(){} // RVA: 0x7FFE871A22F0
        public void TryGetIndex(){} // RVA: 0x7FFE83B23650
        public void TrySetIndex(){} // RVA: 0x7FFE810FB320
        public void TryDeleteIndex(){} // RVA: 0x7FFE810FB320
        public void GetDynamicMemberNames(){} // RVA: 0x7FFE871A2350
        public void GetMetaObject(){} // RVA: 0x7FFE871A2390
    }

    public class ExpandoClass : Object
    {
        public string[] _keys; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871A52A0 | overloaded x2
        public void FindNewClass(){} // RVA: 0x7FFE871A5300
        public void GetTransitionList(){} // RVA: 0x7FFE871A5990
        public void GetValueIndex(){} // RVA: 0x7FFE871A5B30
        public void GetValueIndexCaseSensitive(){} // RVA: 0x7FFE871A5B50
        public void GetValueIndexCaseInsensitive(){} // RVA: 0x7FFE871A5C60
        public void get_Keys(){} // RVA: 0x7FFE81116380
        public void .cctor(){} // RVA: 0x7FFE871A5F10
    }

    public class ExpandoObject : Object
    {
        public System.Reflection.MethodInfo s_expandoTryGetValue;
        public System.Reflection.MethodInfo s_expandoTrySetValue; // 0x8
        public System.Reflection.MethodInfo s_expandoTryDeleteValue; // 0x10
        public System.Reflection.MethodInfo s_expandoPromoteClass; // 0x18
        public System.Reflection.MethodInfo s_expandoCheckVersion; // 0x20
        public object LockObject; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871A6050
        public void TryGetValue(){} // RVA: 0x7FFE871A6180
        public void TrySetValue(){} // RVA: 0x7FFE871A63E0
        public void TryDeleteValue(){} // RVA: 0x7FFE871A6850
        public void IsDeletedMember(){} // RVA: 0x7FFE871A6CE0
        public void get_Class(){} // RVA: 0x7FFE81D29350
        public void PromoteClassCore(){} // RVA: 0x7FFE871A6D80
        public void PromoteClass(){} // RVA: 0x7FFE871A6E10
        public void System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(){} // RVA: 0x7FFE871A7020
        public void TryAddMember(){} // RVA: 0x7FFE871A7110
        public void TryGetValueForKey(){} // RVA: 0x7FFE871A71E0
        public void ExpandoContainsKey(){} // RVA: 0x7FFE871A7210
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys(){} // RVA: 0x7FFE871A7240
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Values(){} // RVA: 0x7FFE871A72A0
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(){} // RVA: 0x7FFE871A7300
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.set_Item(){} // RVA: 0x7FFE871A7370
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(){} // RVA: 0x7FFE871A7110
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(){} // RVA: 0x7FFE871A7440
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(){} // RVA: 0x7FFE871A7580
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(){} // RVA: 0x7FFE871A71E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count(){} // RVA: 0x7FFE8151D690
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(){} // RVA: 0x7FFE871A7670
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear(){} // RVA: 0x7FFE871A7770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(){} // RVA: 0x7FFE871A7AA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(){} // RVA: 0x7FFE871A7B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(){} // RVA: 0x7FFE871A8060
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator(){} // RVA: 0x7FFE871A80E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE871A80E0
        public void GetExpandoEnumerator(){} // RVA: 0x7FFE871A8110
        public void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(){} // RVA: 0x7FFE871A8220
        public void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(){} // RVA: 0x7FFE871A8310
        public void .cctor(){} // RVA: 0x7FFE871A8400
    }

    public class GetIndexBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x7FFE871AD010
        public void FallbackGetIndex(){} // RVA: 0x7FFE80E403A0 | overloaded x2
    }

    public class GetMemberBinder : DynamicMetaObjectBinder
    {
        public string _name; // 0x18
        public bool _ignoreCase; // 0x20
        public object field_2; // 0x3C4
        public object field_3; // 0x3C5

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871AD100
        public void get_ReturnType(){} // RVA: 0x7FFE871AD230
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void get_IgnoreCase(){} // RVA: 0x7FFE811E99D0
        public void FallbackGetMember(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
        public void Bind(){} // RVA: 0x7FFE871AD2E0
        public void get_IsStandardBinder(){} // RVA: 0x7FFE811E0850
    }

    public class IDynamicMetaObjectProvider
    {
        // ── Methods ──
        public void GetMetaObject(){} // RVA: 0x7FFE80E2E390
    }

    public class InvokeBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void FallbackInvoke(){} // RVA: 0x7FFE80E403A0 | overloaded x2
        public void Bind(){} // RVA: 0x7FFE871AD3E0
    }

    public class InvokeMemberBinder : DynamicMetaObjectBinder
    {
        public string _name; // 0x18
        public bool _ignoreCase; // 0x20

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void get_IgnoreCase(){} // RVA: 0x7FFE811E99D0
        public void Bind(){} // RVA: 0x7FFE871AD4D0
        public void FallbackInvokeMember(){} // RVA: 0x7FFE80E403A0 | overloaded x2
        public void FallbackInvoke(){} // RVA: 0x7FFE80E403A0
    }

    public class SetIndexBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x7FFE871AD5C0
        public void FallbackSetIndex(){} // RVA: 0x7FFE80E40660 | overloaded x2
    }

    public class SetMemberBinder : DynamicMetaObjectBinder
    {
        public string _name; // 0x18
        public bool _ignoreCase; // 0x20
        public object field_2; // 0x3CA
        public object field_3; // 0x3CB

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871AD800
        public void get_ReturnType(){} // RVA: 0x7FFE871AD930
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void get_IgnoreCase(){} // RVA: 0x7FFE811E99D0
        public void Bind(){} // RVA: 0x7FFE871AD9E0
        public void get_IsStandardBinder(){} // RVA: 0x7FFE811E0850
        public void FallbackSetMember(){} // RVA: 0x7FFE80E403A0 | overloaded x2
    }

    public class UnaryOperationBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void FallbackUnaryOperation(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
        public void Bind(){} // RVA: 0x7FFE871ADB80
    }

}