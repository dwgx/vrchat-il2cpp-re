// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Dynamic
// Classes: 19
// Methods: 134

namespace ThirdParty.DotNet.System.Dynamic
{
    public class BinaryOperationBinder : DynamicMetaObjectBinder
    {
        public object _operation;

        // ── Methods ──
        public void get_Operation(){} // RVA: 0xE62D00
        public void FallbackBinaryOperation(){} // RVA: 0x882090
        public void Bind(){} // RVA: 0x70CA190
    }

    public class BindingRestrictions : Object
    {
        public object Empty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void GetExpression(){} // RVA: 0x87C0A0
        public void Merge(){} // RVA: 0x70CA330
        public void GetTypeRestriction(){} // RVA: 0x70CA750
        public void GetInstanceRestriction(){} // RVA: 0x70CA820
        public void ToExpression(){} // RVA: 0xBFA210
        public void .cctor(){} // RVA: 0x70CA9C0
    }

    public class ConvertBinder : DynamicMetaObjectBinder
    {
        public object _type;

        // ── Methods ──
        public void get_Type(){} // RVA: 0xB465B0
        public void FallbackConvert(){} // RVA: 0x87C5F0
        public void Bind(){} // RVA: 0x70CC230
    }

    public class CreateInstanceBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void FallbackCreateInstance(){} // RVA: 0x882090
        public void Bind(){} // RVA: 0x70CC330
    }

    public class DeleteIndexBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x70CC420
        public void FallbackDeleteIndex(){} // RVA: 0x882090
    }

    public class DeleteMemberBinder : DynamicMetaObjectBinder
    {
        public object _name;
        public object _ignoreCase;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB465B0
        public void get_IgnoreCase(){} // RVA: 0xC38360
        public void FallbackDeleteMember(){} // RVA: 0x87C5F0
        public void Bind(){} // RVA: 0x70CC510
    }

    public class DynamicMetaObject : Object
    {
        public object EmptyMetaObjects;
        public object s_noValueSentinel;
        public object _value;
        public object _expression;
        public object _restrictions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70CC850
        public void get_Expression(){} // RVA: 0xB465B0
        public void get_Restrictions(){} // RVA: 0xB700F0
        public void get_Value(){} // RVA: 0x70CC8C0
        public void get_HasValue(){} // RVA: 0x70CC940
        public void get_RuntimeType(){} // RVA: 0x70CC9B0
        public void get_LimitType(){} // RVA: 0x70CCAA0
        public void BindConvert(){} // RVA: 0x70CCBA0
        public void BindGetMember(){} // RVA: 0x70CCC50
        public void BindSetMember(){} // RVA: 0x70CCD00
        public void BindDeleteMember(){} // RVA: 0x70CCDD0
        public void BindGetIndex(){} // RVA: 0x70CCE80
        public void BindSetIndex(){} // RVA: 0x70CCF50
        public void BindDeleteIndex(){} // RVA: 0x70CD030
        public void BindInvokeMember(){} // RVA: 0x70CD100
        public void BindInvoke(){} // RVA: 0x70CD1D0
        public void BindCreateInstance(){} // RVA: 0x70CD2A0
        public void BindUnaryOperation(){} // RVA: 0x70CD370
        public void BindBinaryOperation(){} // RVA: 0x70CD420
        public void GetDynamicMemberNames(){} // RVA: 0x70CD4F0
        public void GetExpressions(){} // RVA: 0x70CD530
        public void Create(){} // RVA: 0x70CD740
        public void .cctor(){} // RVA: 0x70CD8F0
    }

    public class DynamicMetaObjectBinder : CallSiteBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x70CDA40
        public void get_ReturnType(){} // RVA: 0x6AAD9D0
        public void Bind(){} // RVA: 0x87C5F0
        public void CreateArgumentMetaObjects(){} // RVA: 0x70CE240
        public void GetUpdateExpression(){} // RVA: 0x70CE460
        public void get_IsStandardBinder(){} // RVA: 0xB43320
    }

    public class DynamicObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void TryGetMember(){} // RVA: 0x70CE570
        public void TrySetMember(){} // RVA: 0xB43320
        public void TryDeleteMember(){} // RVA: 0xB43320
        public void TryInvokeMember(){} // RVA: 0x3896A30
        public void TryConvert(){} // RVA: 0x70CE570
        public void TryCreateInstance(){} // RVA: 0x3896A30
        public void TryInvoke(){} // RVA: 0x3896A30
        public void TryBinaryOperation(){} // RVA: 0x3896A30
        public void TryUnaryOperation(){} // RVA: 0x70CE570
        public void TryGetIndex(){} // RVA: 0x3896A30
        public void TrySetIndex(){} // RVA: 0xB43320
        public void TryDeleteIndex(){} // RVA: 0xB43320
        public void GetDynamicMemberNames(){} // RVA: 0x70CE5D0
        public void GetMetaObject(){} // RVA: 0x70CE610
    }

    public class ExpandoClass : Object
    {
        public object _keys;
        public object _hashCode;
        public object _transitions;
        public object Empty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70D1300
        public void FindNewClass(){} // RVA: 0x70D1360
        public void GetTransitionList(){} // RVA: 0x70D1980
        public void GetValueIndex(){} // RVA: 0x70D1B20
        public void GetValueIndexCaseSensitive(){} // RVA: 0x70D1B40
        public void GetValueIndexCaseInsensitive(){} // RVA: 0x70D1C50
        public void get_Keys(){} // RVA: 0xB5DBF0
        public void .cctor(){} // RVA: 0x70D1ED0
    }

    public class ExpandoObject : Object
    {
        public object s_expandoTryGetValue;
        public object s_expandoTrySetValue;
        public object s_expandoTryDeleteValue;
        public object s_expandoPromoteClass;
        public object s_expandoCheckVersion;
        public object LockObject;
        public object _data;
        public object _count;
        public object Uninitialized;
        public object _propertyChanged;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70D2010
        public void TryGetValue(){} // RVA: 0x70D2140
        public void TrySetValue(){} // RVA: 0x70D23A0
        public void TryDeleteValue(){} // RVA: 0x70D27E0
        public void IsDeletedMember(){} // RVA: 0x70D2C40
        public void get_Class(){} // RVA: 0x1853320
        public void PromoteClassCore(){} // RVA: 0x70D2CE0
        public void PromoteClass(){} // RVA: 0x70D2D70
        public void System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(){} // RVA: 0x70D2F40
        public void TryAddMember(){} // RVA: 0x70D3030
        public void TryGetValueForKey(){} // RVA: 0x70D3100
        public void ExpandoContainsKey(){} // RVA: 0x70D3130
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys(){} // RVA: 0x70D3160
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Values(){} // RVA: 0x70D31C0
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(){} // RVA: 0x70D3220
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.set_Item(){} // RVA: 0x70D3290
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(){} // RVA: 0x70D3030
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(){} // RVA: 0x70D3360
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(){} // RVA: 0x70D34A0
        public void System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(){} // RVA: 0x70D3100
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count(){} // RVA: 0xFEAE90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(){} // RVA: 0x70D3590
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear(){} // RVA: 0x70D3690
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(){} // RVA: 0x70D39B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(){} // RVA: 0x70D3A80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(){} // RVA: 0x70D3F30
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator(){} // RVA: 0x70D3FB0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x70D3FB0
        public void GetExpandoEnumerator(){} // RVA: 0x70D3FE0
        public void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(){} // RVA: 0x70D40F0
        public void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(){} // RVA: 0x70D41E0
        public void .cctor(){} // RVA: 0x70D42D0
    }

    public class GetIndexBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x70D8BA0
        public void FallbackGetIndex(){} // RVA: 0x882090
    }

    public class GetMemberBinder : DynamicMetaObjectBinder
    {
        public object _name;
        public object _ignoreCase;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70D8C90
        public void get_ReturnType(){} // RVA: 0x6AAD9D0
        public void get_Name(){} // RVA: 0xB465B0
        public void get_IgnoreCase(){} // RVA: 0xC38360
        public void FallbackGetMember(){} // RVA: 0x87C5F0
        public void Bind(){} // RVA: 0x70D8DC0
        public void get_IsStandardBinder(){} // RVA: 0xC2E4C0
    }

    public class IDynamicMetaObjectProvider
    {
        // ── Methods ──
        public void GetMetaObject(){} // RVA: 0x87C540
    }

    public class InvokeBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void FallbackInvoke(){} // RVA: 0x882090
        public void Bind(){} // RVA: 0x70D8EC0
    }

    public class InvokeMemberBinder : DynamicMetaObjectBinder
    {
        public object _name;
        public object _ignoreCase;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB465B0
        public void get_IgnoreCase(){} // RVA: 0xC38360
        public void Bind(){} // RVA: 0x70D8FB0
        public void FallbackInvokeMember(){} // RVA: 0x882090
        public void FallbackInvoke(){} // RVA: 0x882090
    }

    public class SetIndexBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x70D90A0
        public void FallbackSetIndex(){} // RVA: 0x88D2C0
    }

    public class SetMemberBinder : DynamicMetaObjectBinder
    {
        public object _name;
        public object _ignoreCase;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70D92E0
        public void get_ReturnType(){} // RVA: 0x6AAD9D0
        public void get_Name(){} // RVA: 0xB465B0
        public void get_IgnoreCase(){} // RVA: 0xC38360
        public void Bind(){} // RVA: 0x70D9410
        public void get_IsStandardBinder(){} // RVA: 0xC2E4C0
        public void FallbackSetMember(){} // RVA: 0x882090
    }

    public class UnaryOperationBinder : DynamicMetaObjectBinder
    {
        // ── Methods ──
        public void FallbackUnaryOperation(){} // RVA: 0x87C5F0
        public void Bind(){} // RVA: 0x70D95B0
    }

}