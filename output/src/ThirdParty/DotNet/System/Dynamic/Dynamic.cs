// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Dynamic
// Classes: 19
// Methods: 150

namespace ThirdParty.DotNet.System.Dynamic
{
    public class BinaryOperationBinder : DynamicMetaObjectBinder
    {
        public 0x6B1EC490 Operation; // 0x18

        // ── Methods ──
        public void get_Operation(){} // RVA: 0x7FFAC3157800
        public void FallbackBinaryOperation(){} // RVA: 0x7FFAC2C6AE80 | overloaded x2
        public void Bind(){} // RVA: 0x7FFAC8DF5AB0
    }

    public class BindingRestrictions : Object
    {
        public System.Dynamic.BindingRestrictions Empty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void GetExpression(){} // RVA: 0x7FFAC2C58E90
        public void Merge(){} // RVA: 0x7FFAC8DF5C50
        public void GetTypeRestriction(){} // RVA: 0x7FFAC8DF6070 | overloaded x2
        public void GetInstanceRestriction(){} // RVA: 0x7FFAC8DF6140
        public void ToExpression(){} // RVA: 0x7FFAC2FD5BC0
        public void .cctor(){} // RVA: 0x7FFAC8DF62E0
    }

    public class ConvertBinder : DynamicMetaObjectBinder
    {
        public System.Type Type; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2F247C0
        public void FallbackConvert(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
        public void Bind(){} // RVA: 0x7FFAC8DF7AD0
    }

    public class CreateInstanceBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void FallbackCreateInstance(){} // RVA: 0x7FFAC2C6AE80 | overloaded x2
        public void Bind(){} // RVA: 0x7FFAC8DF7BD0
    }

    public class DeleteIndexBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x7FFAC8DF7CC0
        public void FallbackDeleteIndex(){} // RVA: 0x7FFAC2C6AE80 | overloaded x2
    }

    public class DeleteMemberBinder : DynamicMetaObjectBinder
    {
        public string Name; // 0x18
        public bool IgnoreCase; // 0x20

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void get_IgnoreCase(){} // RVA: 0x7FFAC300F9D0
        public void FallbackDeleteMember(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
        public void Bind(){} // RVA: 0x7FFAC8DF7DB0
    }

    public class DynamicMetaObject : Object
    {
        public System.Dynamic.DynamicMetaObject[] Expression;
        public object Restrictions; // 0x8
        public object Value; // 0x10
        public System.Linq.Expressions.Expression HasValue; // 0x18
        public System.Dynamic.BindingRestrictions RuntimeType; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DF80F0 | overloaded x2
        public void get_Expression(){} // RVA: 0x7FFAC2F247C0
        public void get_Restrictions(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Value(){} // RVA: 0x7FFAC8DF8160
        public void get_HasValue(){} // RVA: 0x7FFAC8DF81E0
        public void get_RuntimeType(){} // RVA: 0x7FFAC8DF8250
        public void get_LimitType(){} // RVA: 0x7FFAC8DF8340
        public void BindConvert(){} // RVA: 0x7FFAC8DF8440
        public void BindGetMember(){} // RVA: 0x7FFAC8DF84F0
        public void BindSetMember(){} // RVA: 0x7FFAC8DF85A0
        public void BindDeleteMember(){} // RVA: 0x7FFAC8DF8670
        public void BindGetIndex(){} // RVA: 0x7FFAC8DF8720
        public void BindSetIndex(){} // RVA: 0x7FFAC8DF87F0
        public void BindDeleteIndex(){} // RVA: 0x7FFAC8DF88D0
        public void BindInvokeMember(){} // RVA: 0x7FFAC8DF89A0
        public void BindInvoke(){} // RVA: 0x7FFAC8DF8A70
        public void BindCreateInstance(){} // RVA: 0x7FFAC8DF8B40
        public void BindUnaryOperation(){} // RVA: 0x7FFAC8DF8C10
        public void BindBinaryOperation(){} // RVA: 0x7FFAC8DF8CC0
        public void GetDynamicMemberNames(){} // RVA: 0x7FFAC8DF8D90
        public void GetExpressions(){} // RVA: 0x7FFAC8DF8DD0
        public void Create(){} // RVA: 0x7FFAC8DF8FC0
        public void .cctor(){} // RVA: 0x7FFAC8DF9170
    }

    public class DynamicMetaObjectBinder : CallSiteBinder
    {
        public object ReturnType;
        public object IsStandardBinder;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DF92C0
        public void get_ReturnType(){} // RVA: 0x7FFAC8DF9310
        public void Bind(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
        public void CreateArgumentMetaObjects(){} // RVA: 0x7FFAC8DF9BA0
        public void GetUpdateExpression(){} // RVA: 0x7FFAC8DF9DB0
        public void get_IsStandardBinder(){} // RVA: 0x7FFAC2F21320
    }

    public class DynamicObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void TryGetMember(){} // RVA: 0x7FFAC8DF9EC0
        public void TrySetMember(){} // RVA: 0x7FFAC2F21320
        public void TryDeleteMember(){} // RVA: 0x7FFAC2F21320
        public void TryInvokeMember(){} // RVA: 0x7FFAC58074C0
        public void TryConvert(){} // RVA: 0x7FFAC8DF9EC0
        public void TryCreateInstance(){} // RVA: 0x7FFAC58074C0
        public void TryInvoke(){} // RVA: 0x7FFAC58074C0
        public void TryBinaryOperation(){} // RVA: 0x7FFAC58074C0
        public void TryUnaryOperation(){} // RVA: 0x7FFAC8DF9EC0
        public void TryGetIndex(){} // RVA: 0x7FFAC58074C0
        public void TrySetIndex(){} // RVA: 0x7FFAC2F21320
        public void TryDeleteIndex(){} // RVA: 0x7FFAC2F21320
        public void GetDynamicMemberNames(){} // RVA: 0x7FFAC8DF9F20
        public void GetMetaObject(){} // RVA: 0x7FFAC8DF9F60
    }

    public class ExpandoClass : Object
    {
        public string[] Keys; // 0x10
        public int _hashCode; // 0x18
        public System.Collections.Generic.Dictionary`2<int,System.Collections.Generic.List`1<System.WeakReference>> _transitions; // 0x20
        public System.Dynamic.ExpandoClass Empty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DFCE70 | overloaded x2
        public void FindNewClass(){} // RVA: 0x7FFAC8DFCED0
        public void GetTransitionList(){} // RVA: 0x7FFAC8DFD560
        public void GetValueIndex(){} // RVA: 0x7FFAC8DFD700
        public void GetValueIndexCaseSensitive(){} // RVA: 0x7FFAC8DFD720
        public void GetValueIndexCaseInsensitive(){} // RVA: 0x7FFAC8DFD830
        public void get_Keys(){} // RVA: 0x7FFAC2F3C380
        public void .cctor(){} // RVA: 0x7FFAC8DFDAE0
    }

    public class ExpandoObject : Object
    {
        public System.Reflection.MethodInfo Class;
        public System.Reflection.MethodInfo System.Collections.Generic.IDictionary<System.String,System.Object>.Keys; // 0x8
        public System.Reflection.MethodInfo System.Collections.Generic.IDictionary<System.String,System.Object>.Values; // 0x10
        public System.Reflection.MethodInfo System.Collections.Generic.IDictionary<System.String,System.Object>.Item; // 0x18
        public System.Reflection.MethodInfo System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count; // 0x20
        public object System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly; // 0x10
        public ExpandoData _data; // 0x18
        public int _count; // 0x20
        public object Uninitialized; // 0x28
        public System.ComponentModel.PropertyChangedEventHandler _propertyChanged; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DFDC20
        public void TryGetValue(){} // RVA: 0x7FFAC8DFDD50
        public void TrySetValue(){} // RVA: 0x7FFAC8DFDFB0
        public void TryDeleteValue(){} // RVA: 0x7FFAC8DFE420
        public void IsDeletedMember(){} // RVA: 0x7FFAC8DFE8B0
        public void get_Class(){} // RVA: 0x7FFAC356C7D0
        public void PromoteClassCore(){} // RVA: 0x7FFAC8DFE950
        public void PromoteClass(){} // RVA: 0x7FFAC8DFE9E0
        public void System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(){} // RVA: 0x7FFAC8DFEBF0
        public void TryAddMember(){} // RVA: 0x7FFAC8DFECE0
        public void TryGetValueForKey(){} // RVA: 0x7FFAC8DFEDB0
        public void ExpandoContainsKey(){} // RVA: 0x7FFAC8DFEDE0
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys(){} // RVA: 0x7FFAC8DFEE10
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Values(){} // RVA: 0x7FFAC8DFEE70
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(){} // RVA: 0x7FFAC8DFEED0
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.set_Item(){} // RVA: 0x7FFAC8DFEF40
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(){} // RVA: 0x7FFAC8DFECE0
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(){} // RVA: 0x7FFAC8DFF010
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(){} // RVA: 0x7FFAC8DFF150
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(){} // RVA: 0x7FFAC8DFEDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count(){} // RVA: 0x7FFAC30DBBE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(){} // RVA: 0x7FFAC8DFF240
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear(){} // RVA: 0x7FFAC8DFF340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(){} // RVA: 0x7FFAC8DFF670
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(){} // RVA: 0x7FFAC8DFF740
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(){} // RVA: 0x7FFAC8DFFC30
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator(){} // RVA: 0x7FFAC8DFFCB0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8DFFCB0
        public void GetExpandoEnumerator(){} // RVA: 0x7FFAC8DFFCE0
        public void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(){} // RVA: 0x7FFAC8DFFDF0
        public void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(){} // RVA: 0x7FFAC8DFFEE0
        public void .cctor(){} // RVA: 0x7FFAC8DFFFD0
    }

    public class GetIndexBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x7FFAC8E04BE0
        public void FallbackGetIndex(){} // RVA: 0x7FFAC2C6AE80 | overloaded x2
    }

    public class GetMemberBinder : DynamicMetaObjectBinder
    {
        public string ReturnType; // 0x18
        public bool Name; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E04CD0
        public void get_ReturnType(){} // RVA: 0x7FFAC8E04E00
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void get_IgnoreCase(){} // RVA: 0x7FFAC300F9D0
        public void FallbackGetMember(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
        public void Bind(){} // RVA: 0x7FFAC8E04EB0
        public void get_IsStandardBinder(){} // RVA: 0x7FFAC3006850
    }

    public class IDynamicMetaObjectProvider
    {
        // ── Methods ──
        public void GetMetaObject(){} // RVA: 0x7FFAC2C58F40
    }

    public class InvokeBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void FallbackInvoke(){} // RVA: 0x7FFAC2C6AE80 | overloaded x2
        public void Bind(){} // RVA: 0x7FFAC8E04FB0
    }

    public class InvokeMemberBinder : DynamicMetaObjectBinder
    {
        public string Name; // 0x18
        public bool IgnoreCase; // 0x20

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void get_IgnoreCase(){} // RVA: 0x7FFAC300F9D0
        public void Bind(){} // RVA: 0x7FFAC8E050A0
        public void FallbackInvokeMember(){} // RVA: 0x7FFAC2C6AE80 | overloaded x2
        public void FallbackInvoke(){} // RVA: 0x7FFAC2C6AE80
    }

    public class SetIndexBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x7FFAC8E05190
        public void FallbackSetIndex(){} // RVA: 0x7FFAC2C6B140 | overloaded x2
    }

    public class SetMemberBinder : DynamicMetaObjectBinder
    {
        public string ReturnType; // 0x18
        public bool Name; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E053D0
        public void get_ReturnType(){} // RVA: 0x7FFAC8E05500
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void get_IgnoreCase(){} // RVA: 0x7FFAC300F9D0
        public void Bind(){} // RVA: 0x7FFAC8E055B0
        public void get_IsStandardBinder(){} // RVA: 0x7FFAC3006850
        public void FallbackSetMember(){} // RVA: 0x7FFAC2C6AE80 | overloaded x2
    }

    public class UnaryOperationBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void FallbackUnaryOperation(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
        public void Bind(){} // RVA: 0x7FFAC8E05750
    }

}