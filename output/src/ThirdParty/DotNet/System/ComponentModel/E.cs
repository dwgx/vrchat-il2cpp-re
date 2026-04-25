// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 9
// Methods: 110

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class EditorAttribute : Attribute
    {
        public string EditorBaseTypeName; // 0x10
        public string EditorTypeName; // 0x18
        public string TypeId; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93FABE0 | overloaded x4
        public void get_EditorBaseTypeName(){} // RVA: 0x7FFAC2F247C0
        public void get_EditorTypeName(){} // RVA: 0x7FFAC2F4F0C0
        public void get_TypeId(){} // RVA: 0x7FFAC93FACF0
        public void Equals(){} // RVA: 0x7FFAC93FADE0
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
    }

    public class EditorBrowsableAttribute : Attribute
    {
        public 0x6B1325C0 State; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC369FBB0 | overloaded x2
        public void get_State(){} // RVA: 0x7FFAC2F6E5C0
        public void Equals(){} // RVA: 0x7FFAC93E3B10
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
    }

    public class EnumConverter : TypeConverter
    {
        public StandardValuesCollection EnumType; // 0x10
        public System.Type Values; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F87E80
        public void get_EnumType(){} // RVA: 0x7FFAC2F247C0
        public void get_Values(){} // RVA: 0x7FFAC2F3C380
        public void set_Values(){} // RVA: 0x7FFAC2F22E30
        public void CanConvertFrom(){} // RVA: 0x7FFAC941E0F0
        public void CanConvertTo(){} // RVA: 0x7FFAC941E220
        public void get_Comparer(){} // RVA: 0x7FFAC941E350
        public void ConvertFrom(){} // RVA: 0x7FFAC941E3B0
        public void ConvertTo(){} // RVA: 0x7FFAC941E890
        public void GetStandardValues(){} // RVA: 0x7FFAC941F840
        public void GetStandardValuesExclusive(){} // RVA: 0x7FFAC941FCC0
        public void GetStandardValuesSupported(){} // RVA: 0x7FFAC3006850
        public void IsValid(){} // RVA: 0x7FFAC941FDB0
    }

    public class EventDescriptor : MemberDescriptor
    {
        public object ComponentType;
        public object EventType;
        public object IsMulticast;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93FAF20 | overloaded x3
        public void get_ComponentType(){} // RVA: 0x7FFAC2C58E90
        public void get_EventType(){} // RVA: 0x7FFAC2C58E90
        public void get_IsMulticast(){} // RVA: 0x7FFAC2C59D00
        public void AddEventHandler(){} // RVA: 0x7FFAC2C79B30
        public void RemoveEventHandler(){} // RVA: 0x7FFAC2C79B30
    }

    public class EventDescriptorCollection : Object
    {
        public System.ComponentModel.EventDescriptor[] Count; // 0x10
        public string[] Item; // 0x18
        public System.Collections.IComparer Item; // 0x20
        public bool System.Collections.ICollection.IsSynchronized; // 0x28
        public bool System.Collections.ICollection.SyncRoot; // 0x29
        public bool System.Collections.ICollection.Count; // 0x2A
        public System.ComponentModel.EventDescriptorCollection System.Collections.IList.Item;
        public int System.Collections.IList.IsReadOnly; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93FB080 | overloaded x3
        public void get_Count(){} // RVA: 0x7FFAC3C891D0
        public void set_Count(){} // RVA: 0x7FFAC45B6490
        public void get_Item(){} // RVA: 0x7FFAC93FB2D0 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC93FB2F0
        public void Clear(){} // RVA: 0x7FFAC93FB3D0
        public void Contains(){} // RVA: 0x7FFAC93FB430
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC93FB490
        public void EnsureEventsOwned(){} // RVA: 0x7FFAC93FB4E0
        public void EnsureSize(){} // RVA: 0x7FFAC93FB5E0
        public void Find(){} // RVA: 0x7FFAC93FB7A0
        public void IndexOf(){} // RVA: 0x7FFAC93FB9C0
        public void Insert(){} // RVA: 0x7FFAC93FBA20
        public void Remove(){} // RVA: 0x7FFAC93FBB20
        public void RemoveAt(){} // RVA: 0x7FFAC93FBBD0
        public void GetEnumerator(){} // RVA: 0x7FFAC93FBC70
        public void Sort(){} // RVA: 0x7FFAC93FBF30 | overloaded x4
        public void InternalSort(){} // RVA: 0x7FFAC93FC3F0 | overloaded x2
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC34F9180
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFAC3C891D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC93FC510
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC91B6940
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC93FC5F0
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC93FC790
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAC93FC8D0
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFAC93FB3D0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAC93FC990
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC93FCA50
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC93FCBB0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFAC93FCCC0
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFAC4B82F20
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC4B82F20
        public void .cctor(){} // RVA: 0x7FFAC93FCCD0
    }

    public class EventHandlerList : Object
    {
        public ListEntry Item; // 0x10
        public System.ComponentModel.Component _parent; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAC93E7220
        public void set_Item(){} // RVA: 0x7FFAC93E7290
        public void AddHandler(){} // RVA: 0x7FFAC93E73F0
        public void AddHandlers(){} // RVA: 0x7FFAC93E7560
        public void Dispose(){} // RVA: 0x7FFAC7DDDC00
        public void Find(){} // RVA: 0x7FFAC93E7710
        public void RemoveHandler(){} // RVA: 0x7FFAC93E7730
    }

    public class ExpandableObjectConverter : TypeConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void GetProperties(){} // RVA: 0x7FFAC93FCE90
        public void GetPropertiesSupported(){} // RVA: 0x7FFAC3006850
    }

    public class ExtendedPropertyDescriptor : PropertyDescriptor
    {
        public System.ComponentModel.ReflectPropertyDescriptor ComponentType; // 0x88
        public System.ComponentModel.IExtenderProvider IsReadOnly; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93FD2A0 | overloaded x2
        public void CanResetValue(){} // RVA: 0x7FFAC93FD4F0
        public void get_ComponentType(){} // RVA: 0x7FFAC93FD520
        public void get_IsReadOnly(){} // RVA: 0x7FFAC93FD550
        public void get_PropertyType(){} // RVA: 0x7FFAC93FD6A0
        public void get_DisplayName(){} // RVA: 0x7FFAC93FD6D0
        public void GetValue(){} // RVA: 0x7FFAC93FD920
        public void ResetValue(){} // RVA: 0x7FFAC93FD950
        public void SetValue(){} // RVA: 0x7FFAC93FD990
        public void ShouldSerializeValue(){} // RVA: 0x7FFAC93FD9D0
    }

    public class ExtenderProvidedPropertyAttribute : Attribute
    {
        public System.ComponentModel.PropertyDescriptor ExtenderProperty; // 0x10
        public System.ComponentModel.IExtenderProvider Provider; // 0x18
        public System.Type ReceiverType; // 0x20

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC93FDA00
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_ExtenderProperty(){} // RVA: 0x7FFAC2F3C380
        public void set_ExtenderProperty(){} // RVA: 0x7FFAC2F22E30
        public void get_Provider(){} // RVA: 0x7FFAC2F247C0
        public void set_Provider(){} // RVA: 0x7FFAC2F87E80
        public void get_ReceiverType(){} // RVA: 0x7FFAC2F4F0C0
        public void set_ReceiverType(){} // RVA: 0x7FFAC2F4F0D0
        public void Equals(){} // RVA: 0x7FFAC93FDB70
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC93FDC70
    }

}