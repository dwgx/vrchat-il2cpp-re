// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Dynamic
// Classes: 19
// Methods: 134

namespace ThirdParty.DotNet.System.Dynamic
{
    public class BinaryOperationBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void get_Operation(){} // RVA: 0x7A83782A0
        public void FallbackBinaryOperation(){} // RVA: 0x7A7E06710
        public void Bind(){} // RVA: 0x7AE44D9A0
    }

    public class BindingRestrictions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void GetExpression(){} // RVA: 0x7A7E00680
        public void Merge(){} // RVA: 0x7AE44DB40
        public void GetTypeRestriction(){} // RVA: 0x7AE44DF60
        public void GetInstanceRestriction(){} // RVA: 0x7AE44E030
        public void ToExpression(){} // RVA: 0x7A818C700
        public void .cctor(){} // RVA: 0x7AE44E1D0
    }

    public class ConvertBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7A80DA7B0
        public void FallbackConvert(){} // RVA: 0x7A7E00BD0
        public void Bind(){} // RVA: 0x7AE44F9E0
    }

    public class CreateInstanceBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void FallbackCreateInstance(){} // RVA: 0x7A7E06710
        public void Bind(){} // RVA: 0x7AE44FAE0
    }

    public class DeleteIndexBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x7AE44FBD0
        public void FallbackDeleteIndex(){} // RVA: 0x7A7E06710
    }

    public class DeleteMemberBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A80DA7B0
        public void get_IgnoreCase(){} // RVA: 0x7A81C68D0
        public void FallbackDeleteMember(){} // RVA: 0x7A7E00BD0
        public void Bind(){} // RVA: 0x7AE44FCC0
    }

    public class DynamicMetaObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE450000
        public void get_Expression(){} // RVA: 0x7A80DA7B0
        public void get_Restrictions(){} // RVA: 0x7A81052C0
        public void get_Value(){} // RVA: 0x7AE450070
        public void get_HasValue(){} // RVA: 0x7AE4500F0
        public void get_RuntimeType(){} // RVA: 0x7AE450160
        public void get_LimitType(){} // RVA: 0x7AE450250
        public void BindConvert(){} // RVA: 0x7AE450350
        public void BindGetMember(){} // RVA: 0x7AE450400
        public void BindSetMember(){} // RVA: 0x7AE4504B0
        public void BindDeleteMember(){} // RVA: 0x7AE450580
        public void BindGetIndex(){} // RVA: 0x7AE450630
        public void BindSetIndex(){} // RVA: 0x7AE450700
        public void BindDeleteIndex(){} // RVA: 0x7AE4507E0
        public void BindInvokeMember(){} // RVA: 0x7AE4508B0
        public void BindInvoke(){} // RVA: 0x7AE450980
        public void BindCreateInstance(){} // RVA: 0x7AE450A50
        public void BindUnaryOperation(){} // RVA: 0x7AE450B20
        public void BindBinaryOperation(){} // RVA: 0x7AE450BD0
        public void GetDynamicMemberNames(){} // RVA: 0x7AE450CA0
        public void GetExpressions(){} // RVA: 0x7AE450CE0
        public void Create(){} // RVA: 0x7AE450EF0
        public void .cctor(){} // RVA: 0x7AE4510A0
    }

    public class DynamicMetaObjectBinder : CallSiteBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE4511F0
        public void get_ReturnType(){} // RVA: 0x7AE451240
        public void Bind(){} // RVA: 0x7A7E00BD0
        public void CreateArgumentMetaObjects(){} // RVA: 0x7AE451AD0
        public void GetUpdateExpression(){} // RVA: 0x7AE451CF0
        public void get_IsStandardBinder(){} // RVA: 0x7A80D7320
    }

    public class DynamicObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void TryGetMember(){} // RVA: 0x7AE451E00
        public void TrySetMember(){} // RVA: 0x7A80D7320
        public void TryDeleteMember(){} // RVA: 0x7A80D7320
        public void TryInvokeMember(){} // RVA: 0x7AAC6C770
        public void TryConvert(){} // RVA: 0x7AE451E00
        public void TryCreateInstance(){} // RVA: 0x7AAC6C770
        public void TryInvoke(){} // RVA: 0x7AAC6C770
        public void TryBinaryOperation(){} // RVA: 0x7AAC6C770
        public void TryUnaryOperation(){} // RVA: 0x7AE451E00
        public void TryGetIndex(){} // RVA: 0x7AAC6C770
        public void TrySetIndex(){} // RVA: 0x7A80D7320
        public void TryDeleteIndex(){} // RVA: 0x7A80D7320
        public void GetDynamicMemberNames(){} // RVA: 0x7AE451E60
        public void GetMetaObject(){} // RVA: 0x7AE451EA0
    }

    public class ExpandoClass : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE454DC0
        public void FindNewClass(){} // RVA: 0x7AE454E20
        public void GetTransitionList(){} // RVA: 0x7AE455440
        public void GetValueIndex(){} // RVA: 0x7AE4555E0
        public void GetValueIndexCaseSensitive(){} // RVA: 0x7AE455600
        public void GetValueIndexCaseInsensitive(){} // RVA: 0x7AE455710
        public void get_Keys(){} // RVA: 0x7A80F2570
        public void .cctor(){} // RVA: 0x7AE455990
    }

    public class ExpandoObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE455AD0
        public void TryGetValue(){} // RVA: 0x7AE455C00
        public void TrySetValue(){} // RVA: 0x7AE455E60
        public void TryDeleteValue(){} // RVA: 0x7AE4562A0
        public void IsDeletedMember(){} // RVA: 0x7AE456700
        public void get_Class(){} // RVA: 0x7A8D68680
        public void PromoteClassCore(){} // RVA: 0x7AE4567A0
        public void PromoteClass(){} // RVA: 0x7AE456830
        public void System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(){} // RVA: 0x7AE456A00
        public void TryAddMember(){} // RVA: 0x7AE456AF0
        public void TryGetValueForKey(){} // RVA: 0x7AE456BC0
        public void ExpandoContainsKey(){} // RVA: 0x7AE456BF0
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys(){} // RVA: 0x7AE456C20
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Values(){} // RVA: 0x7AE456C80
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(){} // RVA: 0x7AE456CE0
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.set_Item(){} // RVA: 0x7AE456D50
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(){} // RVA: 0x7AE456AF0
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(){} // RVA: 0x7AE456E20
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(){} // RVA: 0x7AE456F60
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(){} // RVA: 0x7AE456BC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count(){} // RVA: 0x7A851DB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(){} // RVA: 0x7AE457050
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear(){} // RVA: 0x7AE457150
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(){} // RVA: 0x7AE457470
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(){} // RVA: 0x7AE457540
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(){} // RVA: 0x7AE4579F0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator(){} // RVA: 0x7AE457A70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AE457A70
        public void GetExpandoEnumerator(){} // RVA: 0x7AE457AA0
        public void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(){} // RVA: 0x7AE457BB0
        public void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(){} // RVA: 0x7AE457CA0
        public void .cctor(){} // RVA: 0x7AE457D90
    }

    public class GetIndexBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x7AE45C840
        public void FallbackGetIndex(){} // RVA: 0x7A7E06710
    }

    public class GetMemberBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE45C930
        public void get_ReturnType(){} // RVA: 0x7AE45CA60
        public void get_Name(){} // RVA: 0x7A80DA7B0
        public void get_IgnoreCase(){} // RVA: 0x7A81C68D0
        public void FallbackGetMember(){} // RVA: 0x7A7E00BD0
        public void Bind(){} // RVA: 0x7AE45CB10
        public void get_IsStandardBinder(){} // RVA: 0x7A81BD750
    }

    public class IDynamicMetaObjectProvider
    {
        // ── Methods ──
        public void GetMetaObject(){} // RVA: 0x7A7E00B20
    }

    public class InvokeBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void FallbackInvoke(){} // RVA: 0x7A7E06710
        public void Bind(){} // RVA: 0x7AE45CC10
    }

    public class InvokeMemberBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A80DA7B0
        public void get_IgnoreCase(){} // RVA: 0x7A81C68D0
        public void Bind(){} // RVA: 0x7AE45CD00
        public void FallbackInvokeMember(){} // RVA: 0x7A7E06710
        public void FallbackInvoke(){} // RVA: 0x7A7E06710
    }

    public class SetIndexBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x7AE45CDF0
        public void FallbackSetIndex(){} // RVA: 0x7A7E12DE0
    }

    public class SetMemberBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE45D030
        public void get_ReturnType(){} // RVA: 0x7AE45D160
        public void get_Name(){} // RVA: 0x7A80DA7B0
        public void get_IgnoreCase(){} // RVA: 0x7A81C68D0
        public void Bind(){} // RVA: 0x7AE45D210
        public void get_IsStandardBinder(){} // RVA: 0x7A81BD750
        public void FallbackSetMember(){} // RVA: 0x7A7E06710
    }

    public class UnaryOperationBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void FallbackUnaryOperation(){} // RVA: 0x7A7E00BD0
        public void Bind(){} // RVA: 0x7AE45D3B0
    }

}