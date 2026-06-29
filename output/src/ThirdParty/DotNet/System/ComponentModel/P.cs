// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 12
// Methods: 115

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class ParenthesizePropertyNameAttribute : Attribute
    {
        public object Default;
        public object needParenthesis;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
        public void get_NeedParenthesis(){} // RVA: 0xC120A0
        public void Equals(){} // RVA: 0x770F4A0
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void IsDefaultAttribute(){} // RVA: 0x770F540
        public void .cctor(){} // RVA: 0x770F5B0
    }

    public class PasswordPropertyTextAttribute : Attribute
    {
        public object Yes;
        public object No;
        public object Default;
        public object _password;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
        public void get_Password(){} // RVA: 0xC120A0
        public void Equals(){} // RVA: 0x76D2D00
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void IsDefaultAttribute(){} // RVA: 0x76D2DA0
        public void .cctor(){} // RVA: 0x76D2E10
    }

    public class ProgressChangedEventArgs : EventArgs
    {
        public object progressPercentage;
        public object userState;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76E9A60
        public void get_ProgressPercentage(){} // RVA: 0xB8F8F0
        public void get_UserState(){} // RVA: 0xB465B0
    }

    public class ProgressChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x23E7ED0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class PropertyChangedEventArgs : EventArgs
    {
        public object _propertyName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76DE490
        public void get_PropertyName(){} // RVA: 0xB5DBF0
    }

    public class PropertyChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x23E7ED0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class PropertyChangingEventArgs : EventArgs
    {
        public object _propertyName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76DE530
        public void get_PropertyName(){} // RVA: 0xB5DBF0
    }

    public class PropertyChangingEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x23E7ED0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class PropertyDescriptor : MemberDescriptor
    {
        public object _converter;
        public object _valueChangedHandlers;
        public object _editors;
        public object _editorTypes;
        public object _editorCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76C2630
        public void get_ComponentType(){} // RVA: 0x87C0A0
        public void get_Converter(){} // RVA: 0x76D2FB0
        public void get_IsLocalizable(){} // RVA: 0x76D32D0
        public void get_IsReadOnly(){} // RVA: 0x87D280
        public void get_SerializationVisibility(){} // RVA: 0x76D3400
        public void get_PropertyType(){} // RVA: 0x87C0A0
        public void AddValueChanged(){} // RVA: 0x76D3510
        public void CanResetValue(){} // RVA: 0x87D350
        public void Equals(){} // RVA: 0x76D36E0
        public void CreateInstance(){} // RVA: 0x76D3880
        public void FillAttributes(){} // RVA: 0x76D3B90
        public void GetChildProperties(){} // RVA: 0x76D3D10
        public void GetEditor(){} // RVA: 0x76D3DD0
        public void GetHashCode(){} // RVA: 0x76D42A0
        public void GetInvocationTarget(){} // RVA: 0x76D4310
        public void GetTypeFromName(){} // RVA: 0x76D4480
        public void GetValue(){} // RVA: 0x87C540
        public void OnValueChanged(){} // RVA: 0x76D46D0
        public void RemoveValueChanged(){} // RVA: 0x76D4780
        public void GetValueChangedHandler(){} // RVA: 0x76D4940
        public void ResetValue(){} // RVA: 0x894320
        public void SetValue(){} // RVA: 0x8943B0
        public void ShouldSerializeValue(){} // RVA: 0x87D350
        public void get_SupportsChangeEvents(){} // RVA: 0xB43320
    }

    public class PropertyDescriptorCollection : Object
    {
        public object Empty;
        public object _cachedFoundProperties;
        public object _cachedIgnoreCase;
        public object _properties;
        public object _namedSort;
        public object _comparer;
        public object _propsOwned;
        public object _needSort;
        public object _readOnly;
        public object _internalSyncObject;
        public object _count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76D4B80
        public void get_Count(){} // RVA: 0xBE5890
        public void set_Count(){} // RVA: 0xBE58A0
        public void get_Item(){} // RVA: 0x6D58150
        public void Add(){} // RVA: 0x76D4E40
        public void Clear(){} // RVA: 0x76D4F20
        public void Contains(){} // RVA: 0x76D4FD0
        public void CopyTo(){} // RVA: 0x76D5030
        public void EnsurePropsOwned(){} // RVA: 0x76D5080
        public void EnsureSize(){} // RVA: 0x76D5180
        public void Find(){} // RVA: 0x76D5340
        public void IndexOf(){} // RVA: 0x76D5960
        public void Insert(){} // RVA: 0x76D59C0
        public void Remove(){} // RVA: 0x76D5AC0
        public void RemoveAt(){} // RVA: 0x76D5B70
        public void Sort(){} // RVA: 0x76D5DF0
        public void InternalSort(){} // RVA: 0x76D62E0
        public void GetEnumerator(){} // RVA: 0x76D6400
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xDAC980
        public void System.Collections.ICollection.get_Count(){} // RVA: 0xBE5890
        public void System.Collections.IList.Clear(){} // RVA: 0x76D64B0
        public void System.Collections.IDictionary.Clear(){} // RVA: 0x76D64B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x74B1B30
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x76D64C0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x76D64D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x76D65A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x76D6600
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x1DC2880
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x1DC2880
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x76D66A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x76D6700
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x76D6B60
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x76D6C90
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x76D6D70
        public void System.Collections.IList.Add(){} // RVA: 0x76D6E20
        public void System.Collections.IList.Contains(){} // RVA: 0x76D6EB0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x76D6F70
        public void System.Collections.IList.Insert(){} // RVA: 0x76D7030
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x1DC2880
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x1DC2880
        public void System.Collections.IList.Remove(){} // RVA: 0x76D7190
        public void System.Collections.IList.get_Item(){} // RVA: 0x76D72A0
        public void System.Collections.IList.set_Item(){} // RVA: 0x76D72C0
        public void .cctor(){} // RVA: 0x76D74E0
    }

    public class PropertyTabAttribute : Attribute
    {
        public object _tabClasses;
        public object _tabClassNames;
        public object _tabScopes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76C0060
        public void get_TabClasses(){} // RVA: 0x76C0260
        public void get_TabClassNames(){} // RVA: 0x76C0610
        public void get_TabScopes(){} // RVA: 0xB700F0
        public void set_TabScopes(){} // RVA: 0xB70100
        public void Equals(){} // RVA: 0x76C08B0
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void InitializeArrays(){} // RVA: 0x76C0A80
    }

    public class ProvidePropertyAttribute : Attribute
    {
        public object _propertyName;
        public object _receiverTypeName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_PropertyName(){} // RVA: 0xB5DBF0
        public void get_ReceiverTypeName(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0x76D78F0
        public void GetHashCode(){} // RVA: 0x76D7A10
        public void get_TypeId(){} // RVA: 0x76AEB20
    }

}