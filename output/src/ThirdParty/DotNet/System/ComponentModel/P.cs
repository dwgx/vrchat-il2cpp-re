// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 12
// Methods: 137

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class ParenthesizePropertyNameAttribute : Attribute
    {
        public System.ComponentModel.ParenthesizePropertyNameAttribute NeedParenthesis;
        public bool needParenthesis; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0 | overloaded x2
        public void get_NeedParenthesis(){} // RVA: 0x7FFAC2FEB5E0
        public void Equals(){} // RVA: 0x7FFAC94490D0
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC9449170
        public void .cctor(){} // RVA: 0x7FFAC94491E0
    }

    public class PasswordPropertyTextAttribute : Attribute
    {
        public System.ComponentModel.PasswordPropertyTextAttribute Password;
        public System.ComponentModel.PasswordPropertyTextAttribute No; // 0x8
        public System.ComponentModel.PasswordPropertyTextAttribute Default; // 0x10
        public bool <Password>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0 | overloaded x2
        public void get_Password(){} // RVA: 0x7FFAC2FEB5E0
        public void Equals(){} // RVA: 0x7FFAC940B580
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC940B620
        public void .cctor(){} // RVA: 0x7FFAC940B690
    }

    public class ProgressChangedEventArgs : EventArgs
    {
        public int ProgressPercentage; // 0x10
        public object UserState; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9422E70
        public void get_ProgressPercentage(){} // RVA: 0x7FFAC2F6E5C0
        public void get_UserState(){} // RVA: 0x7FFAC2F247C0
    }

    public class ProgressChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class PropertyChangedEventArgs : EventArgs
    {
        public string PropertyName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9417840
        public void get_PropertyName(){} // RVA: 0x7FFAC2F3C380
    }

    public class PropertyChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class PropertyChangingEventArgs : EventArgs
    {
        public string PropertyName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC94178E0
        public void get_PropertyName(){} // RVA: 0x7FFAC2F3C380
    }

    public class PropertyChangingEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class PropertyDescriptor : MemberDescriptor
    {
        public System.ComponentModel.TypeConverter ComponentType; // 0x60
        public System.Collections.Hashtable Converter; // 0x68
        public object[] IsLocalizable; // 0x70
        public System.Type[] IsReadOnly; // 0x78
        public int SerializationVisibility; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93FAF20 | overloaded x3
        public void get_ComponentType(){} // RVA: 0x7FFAC2C58E90
        public void get_Converter(){} // RVA: 0x7FFAC940B830
        public void get_IsLocalizable(){} // RVA: 0x7FFAC940BB40
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void get_SerializationVisibility(){} // RVA: 0x7FFAC940BCA0
        public void get_PropertyType(){} // RVA: 0x7FFAC2C58E90
        public void AddValueChanged(){} // RVA: 0x7FFAC940BDE0
        public void CanResetValue(){} // RVA: 0x7FFAC2C59F60
        public void Equals(){} // RVA: 0x7FFAC940BFB0
        public void CreateInstance(){} // RVA: 0x7FFAC940C160
        public void FillAttributes(){} // RVA: 0x7FFAC940C4C0
        public void GetChildProperties(){} // RVA: 0x7FFAC940C640 | overloaded x4
        public void GetEditor(){} // RVA: 0x7FFAC940C700
        public void GetHashCode(){} // RVA: 0x7FFAC940CBF0
        public void GetInvocationTarget(){} // RVA: 0x7FFAC940CC60
        public void GetTypeFromName(){} // RVA: 0x7FFAC940CDE0
        public void GetValue(){} // RVA: 0x7FFAC2C58F40
        public void OnValueChanged(){} // RVA: 0x7FFAC940D040
        public void RemoveValueChanged(){} // RVA: 0x7FFAC940D0F0
        public void GetValueChangedHandler(){} // RVA: 0x7FFAC940D2B0
        public void ResetValue(){} // RVA: 0x7FFAC2C70A40
        public void SetValue(){} // RVA: 0x7FFAC2C79B30
        public void ShouldSerializeValue(){} // RVA: 0x7FFAC2C59F60
        public void get_SupportsChangeEvents(){} // RVA: 0x7FFAC2F21320
    }

    public class PropertyDescriptorCollection : Object
    {
        public System.ComponentModel.PropertyDescriptorCollection Count;
        public System.Collections.IDictionary Item; // 0x10
        public bool Item; // 0x18
        public System.ComponentModel.PropertyDescriptor[] System.Collections.ICollection.IsSynchronized; // 0x20
        public string[] System.Collections.ICollection.SyncRoot; // 0x28
        public System.Collections.IComparer System.Collections.ICollection.Count; // 0x30
        public bool System.Collections.IDictionary.IsFixedSize; // 0x38
        public bool System.Collections.IDictionary.IsReadOnly; // 0x39
        public bool System.Collections.IDictionary.Item; // 0x3A
        public object System.Collections.IDictionary.Keys; // 0x40
        public int System.Collections.IDictionary.Values; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC940D4F0 | overloaded x3
        public void get_Count(){} // RVA: 0x7FFAC2FC20C0
        public void set_Count(){} // RVA: 0x7FFAC2FC20D0
        public void get_Item(){} // RVA: 0x7FFAC8A82750 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC940D7B0
        public void Clear(){} // RVA: 0x7FFAC940D890
        public void Contains(){} // RVA: 0x7FFAC940D940
        public void CopyTo(){} // RVA: 0x7FFAC940D9A0
        public void EnsurePropsOwned(){} // RVA: 0x7FFAC940D9F0
        public void EnsureSize(){} // RVA: 0x7FFAC940DAF0
        public void Find(){} // RVA: 0x7FFAC940DCB0
        public void IndexOf(){} // RVA: 0x7FFAC940E310
        public void Insert(){} // RVA: 0x7FFAC940E370
        public void Remove(){} // RVA: 0x7FFAC940E470
        public void RemoveAt(){} // RVA: 0x7FFAC940E520
        public void Sort(){} // RVA: 0x7FFAC940E7A0 | overloaded x4
        public void InternalSort(){} // RVA: 0x7FFAC940EC60 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAC940ED80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC34F9180
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFAC2FC20C0
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFAC940EE30
        public void System.Collections.IDictionary.Clear(){} // RVA: 0x7FFAC940EE30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC91E30A0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFAC940EE40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAC940EE50
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAC940EF30
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAC940EFD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAC3F7B7C0
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAC3F7B7C0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAC940F070
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAC940F110
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAC940F590
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAC940F6B0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAC940F790
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC940F850
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAC940F8E0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAC940F9A0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC940FA60
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFAC3F7B7C0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC3F7B7C0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC940FBC0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC940FCD0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC940FCF0
        public void .cctor(){} // RVA: 0x7FFAC940FF10
    }

    public class PropertyTabAttribute : Attribute
    {
        public System.Type[] TabClasses; // 0x10
        public string[] TabClassNames; // 0x18
        public 0x6B133C18[] TabScopes; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93F8890 | overloaded x5
        public void get_TabClasses(){} // RVA: 0x7FFAC93F8A90
        public void get_TabClassNames(){} // RVA: 0x7FFAC93F8E50
        public void get_TabScopes(){} // RVA: 0x7FFAC2F4F0C0
        public void set_TabScopes(){} // RVA: 0x7FFAC2F4F0D0
        public void Equals(){} // RVA: 0x7FFAC93F8F80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void InitializeArrays(){} // RVA: 0x7FFAC93F9170 | overloaded x3
    }

    public class ProvidePropertyAttribute : Attribute
    {
        public string PropertyName; // 0x10
        public string ReceiverTypeName; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void get_PropertyName(){} // RVA: 0x7FFAC2F3C380
        public void get_ReceiverTypeName(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC9410320
        public void GetHashCode(){} // RVA: 0x7FFAC9410440
        public void get_TypeId(){} // RVA: 0x7FFAC93E6760
    }

}