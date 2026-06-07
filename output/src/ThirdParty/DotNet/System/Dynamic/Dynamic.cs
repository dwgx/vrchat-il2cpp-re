// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Dynamic
// Classes: 19
// Methods: 150

namespace ThirdParty.DotNet.System.Dynamic
{
    public class BinaryOperationBinder
    {
        // ── Methods ──
        public void get_Operation(){} // RVA: 0x5BED50
        public void FallbackBinaryOperation(){} // RVA: 0x1EE30 | overloaded x2
        public void Bind(){} // RVA: 0x665EFF0
    }

    public class BindingRestrictions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void GetExpression(){} // RVA: 0xCD60
        public void Merge(){} // RVA: 0x665F190
        public void GetTypeRestriction(){} // RVA: 0x665F5B0 | overloaded x2
        public void GetInstanceRestriction(){} // RVA: 0x665F680
        public void ToExpression(){} // RVA: 0x391BC0
        public void .cctor(){} // RVA: 0x665F820
    }

    public class ConvertBinder
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x2E07C0
        public void FallbackConvert(){} // RVA: 0x1E6A0 | overloaded x2
        public void Bind(){} // RVA: 0x6661010
    }

    public class CreateInstanceBinder
    {
        // ── Methods ──
        public void FallbackCreateInstance(){} // RVA: 0x1EE30 | overloaded x2
        public void Bind(){} // RVA: 0x6661110
    }

    public class DeleteIndexBinder
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x6661200
        public void FallbackDeleteIndex(){} // RVA: 0x1EE30 | overloaded x2
    }

    public class DeleteMemberBinder
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x2E07C0
        public void get_IgnoreCase(){} // RVA: 0x3CB9D0
        public void FallbackDeleteMember(){} // RVA: 0x1E6A0 | overloaded x2
        public void Bind(){} // RVA: 0x66612F0
    }

    public class DynamicMetaObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6661630 | overloaded x2
        public void get_Expression(){} // RVA: 0x2E07C0
        public void get_Restrictions(){} // RVA: 0x30B0C0
        public void get_Value(){} // RVA: 0x66616A0
        public void get_HasValue(){} // RVA: 0x6661720
        public void get_RuntimeType(){} // RVA: 0x6661790
        public void get_LimitType(){} // RVA: 0x6661880
        public void BindConvert(){} // RVA: 0x6661980
        public void BindGetMember(){} // RVA: 0x6661A30
        public void BindSetMember(){} // RVA: 0x6661AE0
        public void BindDeleteMember(){} // RVA: 0x6661BB0
        public void BindGetIndex(){} // RVA: 0x6661C60
        public void BindSetIndex(){} // RVA: 0x6661D30
        public void BindDeleteIndex(){} // RVA: 0x6661E10
        public void BindInvokeMember(){} // RVA: 0x6661EE0
        public void BindInvoke(){} // RVA: 0x6661FB0
        public void BindCreateInstance(){} // RVA: 0x6662080
        public void BindUnaryOperation(){} // RVA: 0x6662150
        public void BindBinaryOperation(){} // RVA: 0x6662200
        public void GetDynamicMemberNames(){} // RVA: 0x66622D0
        public void GetExpressions(){} // RVA: 0x6662310
        public void Create(){} // RVA: 0x6662500
        public void .cctor(){} // RVA: 0x66626B0
    }

    public class DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6662800
        public void get_ReturnType(){} // RVA: 0x6662850
        public void Bind(){} // RVA: 0x1E6A0 | overloaded x2
        public void CreateArgumentMetaObjects(){} // RVA: 0x66630E0
        public void GetUpdateExpression(){} // RVA: 0x66632F0
        public void get_IsStandardBinder(){} // RVA: 0x2DD320
    }

    public class DynamicObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void TryGetMember(){} // RVA: 0x6663400
        public void TrySetMember(){} // RVA: 0x2DD320
        public void TryDeleteMember(){} // RVA: 0x2DD320
        public void TryInvokeMember(){} // RVA: 0x2E74D10
        public void TryConvert(){} // RVA: 0x6663400
        public void TryCreateInstance(){} // RVA: 0x2E74D10
        public void TryInvoke(){} // RVA: 0x2E74D10
        public void TryBinaryOperation(){} // RVA: 0x2E74D10
        public void TryUnaryOperation(){} // RVA: 0x6663400
        public void TryGetIndex(){} // RVA: 0x2E74D10
        public void TrySetIndex(){} // RVA: 0x2DD320
        public void TryDeleteIndex(){} // RVA: 0x2DD320
        public void GetDynamicMemberNames(){} // RVA: 0x6663460
        public void GetMetaObject(){} // RVA: 0x66634A0
    }

    public class ExpandoClass
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66663B0 | overloaded x2
        public void FindNewClass(){} // RVA: 0x6666410
        public void GetTransitionList(){} // RVA: 0x6666AA0
        public void GetValueIndex(){} // RVA: 0x6666C40
        public void GetValueIndexCaseSensitive(){} // RVA: 0x6666C60
        public void GetValueIndexCaseInsensitive(){} // RVA: 0x6666D70
        public void get_Keys(){} // RVA: 0x2F8380
        public void .cctor(){} // RVA: 0x6667020
    }

    public class ExpandoObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6667160
        public void TryGetValue(){} // RVA: 0x6667290
        public void TrySetValue(){} // RVA: 0x66674F0
        public void TryDeleteValue(){} // RVA: 0x6667960
        public void IsDeletedMember(){} // RVA: 0x6667DF0
        public void get_Class(){} // RVA: 0xF9DC10
        public void PromoteClassCore(){} // RVA: 0x6667E90
        public void PromoteClass(){} // RVA: 0x6667F20
        public void System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(){} // RVA: 0x6668130
        public void TryAddMember(){} // RVA: 0x6668220
        public void TryGetValueForKey(){} // RVA: 0x66682F0
        public void ExpandoContainsKey(){} // RVA: 0x6668320
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys(){} // RVA: 0x6668350
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Values(){} // RVA: 0x66683B0
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(){} // RVA: 0x6668410
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.set_Item(){} // RVA: 0x6668480
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(){} // RVA: 0x6668220
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(){} // RVA: 0x6668550
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(){} // RVA: 0x6668690
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(){} // RVA: 0x66682F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count(){} // RVA: 0x760030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(){} // RVA: 0x6668780
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear(){} // RVA: 0x6668880
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(){} // RVA: 0x6668BB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(){} // RVA: 0x6668C80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(){} // RVA: 0x6669170
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator(){} // RVA: 0x66691F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x66691F0
        public void GetExpandoEnumerator(){} // RVA: 0x6669220
        public void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(){} // RVA: 0x6669330
        public void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(){} // RVA: 0x6669420
        public void .cctor(){} // RVA: 0x6669510
    }

    public class GetIndexBinder
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x666E120
        public void FallbackGetIndex(){} // RVA: 0x1EE30 | overloaded x2
    }

    public class GetMemberBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x666E210
        public void get_ReturnType(){} // RVA: 0x666E340
        public void get_Name(){} // RVA: 0x2E07C0
        public void get_IgnoreCase(){} // RVA: 0x3CB9D0
        public void FallbackGetMember(){} // RVA: 0x1E6A0 | overloaded x2
        public void Bind(){} // RVA: 0x666E3F0
        public void get_IsStandardBinder(){} // RVA: 0x3C2850
    }

    public class IDynamicMetaObjectProvider
    {
        // ── Methods ──
        public void GetMetaObject(){} // RVA: 0xCE10
    }

    public class InvokeBinder
    {
        // ── Methods ──
        public void FallbackInvoke(){} // RVA: 0x1EE30 | overloaded x2
        public void Bind(){} // RVA: 0x666E4F0
    }

    public class InvokeMemberBinder
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x2E07C0
        public void get_IgnoreCase(){} // RVA: 0x3CB9D0
        public void Bind(){} // RVA: 0x666E5E0
        public void FallbackInvokeMember(){} // RVA: 0x1EE30 | overloaded x2
        public void FallbackInvoke(){} // RVA: 0x1EE30
    }

    public class SetIndexBinder
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x666E6D0
        public void FallbackSetIndex(){} // RVA: 0x1F0F0 | overloaded x2
    }

    public class SetMemberBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x666E910
        public void get_ReturnType(){} // RVA: 0x666EA40
        public void get_Name(){} // RVA: 0x2E07C0
        public void get_IgnoreCase(){} // RVA: 0x3CB9D0
        public void Bind(){} // RVA: 0x666EAF0
        public void get_IsStandardBinder(){} // RVA: 0x3C2850
        public void FallbackSetMember(){} // RVA: 0x1EE30 | overloaded x2
    }

    public class UnaryOperationBinder
    {
        // ── Methods ──
        public void FallbackUnaryOperation(){} // RVA: 0x1E6A0 | overloaded x2
        public void Bind(){} // RVA: 0x666EC90
    }

}