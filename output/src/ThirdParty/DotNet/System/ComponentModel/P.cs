// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 12
// Methods: 137

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class ParenthesizePropertyNameAttribute : Attribute
    {
        public System.ComponentModel.ParenthesizePropertyNameAttribute Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0 | overloaded x2
        public void get_NeedParenthesis(){} // RVA: 0x7FFE811C55E0
        public void Equals(){} // RVA: 0x7FFE877F1820
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void IsDefaultAttribute(){} // RVA: 0x7FFE877F18C0
        public void .cctor(){} // RVA: 0x7FFE877F1930
    }

    public class PasswordPropertyTextAttribute : Attribute
    {
        public System.ComponentModel.PasswordPropertyTextAttribute Yes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0 | overloaded x2
        public void get_Password(){} // RVA: 0x7FFE811C55E0
        public void Equals(){} // RVA: 0x7FFE877B3CB0
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void IsDefaultAttribute(){} // RVA: 0x7FFE877B3D50
        public void .cctor(){} // RVA: 0x7FFE877B3DC0
    }

    public class ProgressChangedEventArgs : EventArgs
    {
        public int progressPercentage; // 0x10
        public object userState; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877CB5A0
        public void get_ProgressPercentage(){} // RVA: 0x7FFE811485C0
        public void get_UserState(){} // RVA: 0x7FFE810FE7C0
    }

    public class ProgressChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE82886970
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class PropertyChangedEventArgs : EventArgs
    {
        public string _propertyName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877BFF70
        public void get_PropertyName(){} // RVA: 0x7FFE81116380
    }

    public class PropertyChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE82886970
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class PropertyChangingEventArgs : EventArgs
    {
        public string _propertyName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877C0010
        public void get_PropertyName(){} // RVA: 0x7FFE81116380
    }

    public class PropertyChangingEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE82886970
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class PropertyDescriptor : MemberDescriptor
    {
        public System.ComponentModel.TypeConverter _converter; // 0x60
        public System.Collections.Hashtable _valueChangedHandlers; // 0x68
        public object[] _editors; // 0x70
        public System.Type[] _editorTypes; // 0x78
        public int _editorCount; // 0x80
        public object field_5; // 0x286
        public object field_6; // 0x287

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877A3650 | overloaded x3
        public void get_ComponentType(){} // RVA: 0x7FFE80E2E2E0
        public void get_Converter(){} // RVA: 0x7FFE877B3F60
        public void get_IsLocalizable(){} // RVA: 0x7FFE877B4270
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void get_SerializationVisibility(){} // RVA: 0x7FFE877B43D0
        public void get_PropertyType(){} // RVA: 0x7FFE80E2E2E0
        public void AddValueChanged(){} // RVA: 0x7FFE877B4510
        public void CanResetValue(){} // RVA: 0x7FFE80E2F3B0
        public void Equals(){} // RVA: 0x7FFE877B46E0
        public void CreateInstance(){} // RVA: 0x7FFE877B4890
        public void FillAttributes(){} // RVA: 0x7FFE877B4BF0
        public void GetChildProperties(){} // RVA: 0x7FFE877B4D70 | overloaded x4
        public void GetEditor(){} // RVA: 0x7FFE877B4E30
        public void GetHashCode(){} // RVA: 0x7FFE877B5320
        public void GetInvocationTarget(){} // RVA: 0x7FFE877B5390
        public void GetTypeFromName(){} // RVA: 0x7FFE877B5510
        public void GetValue(){} // RVA: 0x7FFE80E2E390
        public void OnValueChanged(){} // RVA: 0x7FFE877B5770
        public void RemoveValueChanged(){} // RVA: 0x7FFE877B5820
        public void GetValueChangedHandler(){} // RVA: 0x7FFE877B59E0
        public void ResetValue(){} // RVA: 0x7FFE80E460A0
        public void SetValue(){} // RVA: 0x7FFE80E4F230
        public void ShouldSerializeValue(){} // RVA: 0x7FFE80E2F3B0
        public void get_SupportsChangeEvents(){} // RVA: 0x7FFE810FB320
    }

    public class PropertyDescriptorCollection : Object
    {
        public System.ComponentModel.PropertyDescriptorCollection Empty;
        public System.Collections.IDictionary _cachedFoundProperties; // 0x10
        public bool _cachedIgnoreCase; // 0x18
        public System.ComponentModel.PropertyDescriptor[] _properties; // 0x20
        public string[] _namedSort; // 0x28
        public System.Collections.IComparer _comparer; // 0x30
        public bool _propsOwned; // 0x38
        public bool _needSort; // 0x39
        public bool _readOnly; // 0x3A
        public object _internalSyncObject; // 0x40
        public int _count; // 0x48
        public object field_11; // 0x28D
        public object field_12; // 0x28E
        public object field_13; // 0x28F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877B5C20 | overloaded x3
        public void get_Count(){} // RVA: 0x7FFE8119C0C0
        public void set_Count(){} // RVA: 0x7FFE8119C0D0
        public void get_Item(){} // RVA: 0x7FFE86E2BDE0 | overloaded x2
        public void Add(){} // RVA: 0x7FFE877B5EE0
        public void Clear(){} // RVA: 0x7FFE877B5FC0
        public void Contains(){} // RVA: 0x7FFE877B6070
        public void CopyTo(){} // RVA: 0x7FFE877B60D0
        public void EnsurePropsOwned(){} // RVA: 0x7FFE877B6120
        public void EnsureSize(){} // RVA: 0x7FFE877B6220
        public void Find(){} // RVA: 0x7FFE877B63E0
        public void IndexOf(){} // RVA: 0x7FFE877B6A40
        public void Insert(){} // RVA: 0x7FFE877B6AA0
        public void Remove(){} // RVA: 0x7FFE877B6BA0
        public void RemoveAt(){} // RVA: 0x7FFE877B6C50
        public void Sort(){} // RVA: 0x7FFE877B6ED0 | overloaded x4
        public void InternalSort(){} // RVA: 0x7FFE877B7390 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFE877B74B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE813240E0
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFE8119C0C0
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFE877B7560
        public void System.Collections.IDictionary.Clear(){} // RVA: 0x7FFE877B7560
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8758B810
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFE877B7570
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFE877B7580
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFE877B7660
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFE877B7700
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFE82230840
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFE82230840
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFE877B77A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFE877B7840
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFE877B7CC0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFE877B7DE0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFE877B7EC0
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE877B7F80
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE877B8010
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE877B80D0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE877B8190
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE82230840
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE82230840
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE877B82F0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE877B8400
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE877B8420
        public void .cctor(){} // RVA: 0x7FFE877B8640
    }

    public class PropertyTabAttribute : Attribute
    {
        public System.Type[] _tabClasses; // 0x10
        public string[] _tabClassNames; // 0x18
        public 0x6652CB3C[] _tabScopes; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877A0FC0 | overloaded x5
        public void get_TabClasses(){} // RVA: 0x7FFE877A11C0
        public void get_TabClassNames(){} // RVA: 0x7FFE877A1580
        public void get_TabScopes(){} // RVA: 0x7FFE811290C0
        public void set_TabScopes(){} // RVA: 0x7FFE811290D0
        public void Equals(){} // RVA: 0x7FFE877A16B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void InitializeArrays(){} // RVA: 0x7FFE877A18A0 | overloaded x3
    }

    public class ProvidePropertyAttribute : Attribute
    {
        public string _propertyName; // 0x10
        public string _receiverTypeName; // 0x18
        public object field_2; // 0x29F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void get_PropertyName(){} // RVA: 0x7FFE81116380
        public void get_ReceiverTypeName(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE877B8A50
        public void GetHashCode(){} // RVA: 0x7FFE877B8B70
        public void get_TypeId(){} // RVA: 0x7FFE8778EE90
    }

}