// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Dynamic
// Classes: 19
// Methods: 150

namespace ThirdParty.DotNet.System.Dynamic
{
    public class BinaryOperationBinder
    {
        // ── Methods ──
        public void get_Operation(){} // RVA: 0x7FFAF306ED50
        public void FallbackBinaryOperation(){} // RVA: 0x7FFAF2ACEE30 | overloaded x2
        public void Bind(){} // RVA: 0x7FFAF910EFF0
    }

    public class BindingRestrictions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void GetExpression(){} // RVA: 0x7FFAF2ABCD60
        public void Merge(){} // RVA: 0x7FFAF910F190
        public void GetTypeRestriction(){} // RVA: 0x7FFAF910F5B0 | overloaded x2
        public void GetInstanceRestriction(){} // RVA: 0x7FFAF910F680
        public void ToExpression(){} // RVA: 0x7FFAF2E41BC0
        public void .cctor(){} // RVA: 0x7FFAF910F820
    }

    public class ConvertBinder
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF2D907C0
        public void FallbackConvert(){} // RVA: 0x7FFAF2ACE6A0 | overloaded x2
        public void Bind(){} // RVA: 0x7FFAF9111010
    }

    public class CreateInstanceBinder
    {
        // ── Methods ──
        public void FallbackCreateInstance(){} // RVA: 0x7FFAF2ACEE30 | overloaded x2
        public void Bind(){} // RVA: 0x7FFAF9111110
    }

    public class DeleteIndexBinder
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x7FFAF9111200
        public void FallbackDeleteIndex(){} // RVA: 0x7FFAF2ACEE30 | overloaded x2
    }

    public class DeleteMemberBinder
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2D907C0
        public void get_IgnoreCase(){} // RVA: 0x7FFAF2E7B9D0
        public void FallbackDeleteMember(){} // RVA: 0x7FFAF2ACE6A0 | overloaded x2
        public void Bind(){} // RVA: 0x7FFAF91112F0
    }

    public class DynamicMetaObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9111630 | overloaded x2
        public void get_Expression(){} // RVA: 0x7FFAF2D907C0
        public void get_Restrictions(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Value(){} // RVA: 0x7FFAF91116A0
        public void get_HasValue(){} // RVA: 0x7FFAF9111720
        public void get_RuntimeType(){} // RVA: 0x7FFAF9111790
        public void get_LimitType(){} // RVA: 0x7FFAF9111880
        public void BindConvert(){} // RVA: 0x7FFAF9111980
        public void BindGetMember(){} // RVA: 0x7FFAF9111A30
        public void BindSetMember(){} // RVA: 0x7FFAF9111AE0
        public void BindDeleteMember(){} // RVA: 0x7FFAF9111BB0
        public void BindGetIndex(){} // RVA: 0x7FFAF9111C60
        public void BindSetIndex(){} // RVA: 0x7FFAF9111D30
        public void BindDeleteIndex(){} // RVA: 0x7FFAF9111E10
        public void BindInvokeMember(){} // RVA: 0x7FFAF9111EE0
        public void BindInvoke(){} // RVA: 0x7FFAF9111FB0
        public void BindCreateInstance(){} // RVA: 0x7FFAF9112080
        public void BindUnaryOperation(){} // RVA: 0x7FFAF9112150
        public void BindBinaryOperation(){} // RVA: 0x7FFAF9112200
        public void GetDynamicMemberNames(){} // RVA: 0x7FFAF91122D0
        public void GetExpressions(){} // RVA: 0x7FFAF9112310
        public void Create(){} // RVA: 0x7FFAF9112500
        public void .cctor(){} // RVA: 0x7FFAF91126B0
    }

    public class DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9112800
        public void get_ReturnType(){} // RVA: 0x7FFAF9112850
        public void Bind(){} // RVA: 0x7FFAF2ACE6A0 | overloaded x2
        public void CreateArgumentMetaObjects(){} // RVA: 0x7FFAF91130E0
        public void GetUpdateExpression(){} // RVA: 0x7FFAF91132F0
        public void get_IsStandardBinder(){} // RVA: 0x7FFAF2D8D320
    }

    public class DynamicObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void TryGetMember(){} // RVA: 0x7FFAF9113400
        public void TrySetMember(){} // RVA: 0x7FFAF2D8D320
        public void TryDeleteMember(){} // RVA: 0x7FFAF2D8D320
        public void TryInvokeMember(){} // RVA: 0x7FFAF5924D10
        public void TryConvert(){} // RVA: 0x7FFAF9113400
        public void TryCreateInstance(){} // RVA: 0x7FFAF5924D10
        public void TryInvoke(){} // RVA: 0x7FFAF5924D10
        public void TryBinaryOperation(){} // RVA: 0x7FFAF5924D10
        public void TryUnaryOperation(){} // RVA: 0x7FFAF9113400
        public void TryGetIndex(){} // RVA: 0x7FFAF5924D10
        public void TrySetIndex(){} // RVA: 0x7FFAF2D8D320
        public void TryDeleteIndex(){} // RVA: 0x7FFAF2D8D320
        public void GetDynamicMemberNames(){} // RVA: 0x7FFAF9113460
        public void GetMetaObject(){} // RVA: 0x7FFAF91134A0
    }

    public class ExpandoClass
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF91163B0 | overloaded x2
        public void FindNewClass(){} // RVA: 0x7FFAF9116410
        public void GetTransitionList(){} // RVA: 0x7FFAF9116AA0
        public void GetValueIndex(){} // RVA: 0x7FFAF9116C40
        public void GetValueIndexCaseSensitive(){} // RVA: 0x7FFAF9116C60
        public void GetValueIndexCaseInsensitive(){} // RVA: 0x7FFAF9116D70
        public void get_Keys(){} // RVA: 0x7FFAF2DA8380
        public void .cctor(){} // RVA: 0x7FFAF9117020
    }

    public class ExpandoObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9117160
        public void TryGetValue(){} // RVA: 0x7FFAF9117290
        public void TrySetValue(){} // RVA: 0x7FFAF91174F0
        public void TryDeleteValue(){} // RVA: 0x7FFAF9117960
        public void IsDeletedMember(){} // RVA: 0x7FFAF9117DF0
        public void get_Class(){} // RVA: 0x7FFAF3A4DC10
        public void PromoteClassCore(){} // RVA: 0x7FFAF9117E90
        public void PromoteClass(){} // RVA: 0x7FFAF9117F20
        public void System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(){} // RVA: 0x7FFAF9118130
        public void TryAddMember(){} // RVA: 0x7FFAF9118220
        public void TryGetValueForKey(){} // RVA: 0x7FFAF91182F0
        public void ExpandoContainsKey(){} // RVA: 0x7FFAF9118320
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys(){} // RVA: 0x7FFAF9118350
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Values(){} // RVA: 0x7FFAF91183B0
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(){} // RVA: 0x7FFAF9118410
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.set_Item(){} // RVA: 0x7FFAF9118480
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(){} // RVA: 0x7FFAF9118220
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(){} // RVA: 0x7FFAF9118550
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(){} // RVA: 0x7FFAF9118690
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(){} // RVA: 0x7FFAF91182F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count(){} // RVA: 0x7FFAF3210030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(){} // RVA: 0x7FFAF9118780
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear(){} // RVA: 0x7FFAF9118880
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(){} // RVA: 0x7FFAF9118BB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(){} // RVA: 0x7FFAF9118C80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(){} // RVA: 0x7FFAF9119170
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator(){} // RVA: 0x7FFAF91191F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF91191F0
        public void GetExpandoEnumerator(){} // RVA: 0x7FFAF9119220
        public void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(){} // RVA: 0x7FFAF9119330
        public void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(){} // RVA: 0x7FFAF9119420
        public void .cctor(){} // RVA: 0x7FFAF9119510
    }

    public class GetIndexBinder
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x7FFAF911E120
        public void FallbackGetIndex(){} // RVA: 0x7FFAF2ACEE30 | overloaded x2
    }

    public class GetMemberBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF911E210
        public void get_ReturnType(){} // RVA: 0x7FFAF911E340
        public void get_Name(){} // RVA: 0x7FFAF2D907C0
        public void get_IgnoreCase(){} // RVA: 0x7FFAF2E7B9D0
        public void FallbackGetMember(){} // RVA: 0x7FFAF2ACE6A0 | overloaded x2
        public void Bind(){} // RVA: 0x7FFAF911E3F0
        public void get_IsStandardBinder(){} // RVA: 0x7FFAF2E72850
    }

    public class IDynamicMetaObjectProvider
    {
        // ── Methods ──
        public void GetMetaObject(){} // RVA: 0x7FFAF2ABCE10
    }

    public class InvokeBinder
    {
        // ── Methods ──
        public void FallbackInvoke(){} // RVA: 0x7FFAF2ACEE30 | overloaded x2
        public void Bind(){} // RVA: 0x7FFAF911E4F0
    }

    public class InvokeMemberBinder
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2D907C0
        public void get_IgnoreCase(){} // RVA: 0x7FFAF2E7B9D0
        public void Bind(){} // RVA: 0x7FFAF911E5E0
        public void FallbackInvokeMember(){} // RVA: 0x7FFAF2ACEE30 | overloaded x2
        public void FallbackInvoke(){} // RVA: 0x7FFAF2ACEE30
    }

    public class SetIndexBinder
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x7FFAF911E6D0
        public void FallbackSetIndex(){} // RVA: 0x7FFAF2ACF0F0 | overloaded x2
    }

    public class SetMemberBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF911E910
        public void get_ReturnType(){} // RVA: 0x7FFAF911EA40
        public void get_Name(){} // RVA: 0x7FFAF2D907C0
        public void get_IgnoreCase(){} // RVA: 0x7FFAF2E7B9D0
        public void Bind(){} // RVA: 0x7FFAF911EAF0
        public void get_IsStandardBinder(){} // RVA: 0x7FFAF2E72850
        public void FallbackSetMember(){} // RVA: 0x7FFAF2ACEE30 | overloaded x2
    }

    public class UnaryOperationBinder
    {
        // ── Methods ──
        public void FallbackUnaryOperation(){} // RVA: 0x7FFAF2ACE6A0 | overloaded x2
        public void Bind(){} // RVA: 0x7FFAF911EC90
    }

}