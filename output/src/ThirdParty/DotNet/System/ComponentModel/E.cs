// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 9
// Methods: 110

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class EditorAttribute : Attribute
    {
        public string _typeId; // 0x10
        public string _editorBaseTypeName; // 0x18
        public string _editorTypeName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877A3310 | overloaded x4
        public void get_EditorBaseTypeName(){} // RVA: 0x7FFE810FE7C0
        public void get_EditorTypeName(){} // RVA: 0x7FFE811290C0
        public void get_TypeId(){} // RVA: 0x7FFE877A3420
        public void Equals(){} // RVA: 0x7FFE877A3510
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
    }

    public class EditorBrowsableAttribute : Attribute
    {
        public 0x6652B4E4 browsableState; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE817EE4A0 | overloaded x2
        public void get_State(){} // RVA: 0x7FFE811485C0
        public void Equals(){} // RVA: 0x7FFE8778C240
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
    }

    public class EnumConverter : TypeConverter
    {
        public StandardValuesCollection values; // 0x10
        public System.Type type; // 0x18
        public object field_2; // 0x2E2

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81161E80
        public void get_EnumType(){} // RVA: 0x7FFE810FE7C0
        public void get_Values(){} // RVA: 0x7FFE81116380
        public void set_Values(){} // RVA: 0x7FFE810FCE30
        public void CanConvertFrom(){} // RVA: 0x7FFE877C6820
        public void CanConvertTo(){} // RVA: 0x7FFE877C6950
        public void get_Comparer(){} // RVA: 0x7FFE877C6A80
        public void ConvertFrom(){} // RVA: 0x7FFE877C6AE0
        public void ConvertTo(){} // RVA: 0x7FFE877C6FC0
        public void GetStandardValues(){} // RVA: 0x7FFE877C7F70
        public void GetStandardValuesExclusive(){} // RVA: 0x7FFE877C83F0
        public void GetStandardValuesSupported(){} // RVA: 0x7FFE811E0850
        public void IsValid(){} // RVA: 0x7FFE877C84E0
    }

    public class EventDescriptor : MemberDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877A3650 | overloaded x3
        public void get_ComponentType(){} // RVA: 0x7FFE80E2E2E0
        public void get_EventType(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsMulticast(){} // RVA: 0x7FFE80E2F150
        public void AddEventHandler(){} // RVA: 0x7FFE80E4F230
        public void RemoveEventHandler(){} // RVA: 0x7FFE80E4F230
    }

    public class EventDescriptorCollection : Object
    {
        public System.ComponentModel.EventDescriptor[] _events; // 0x10
        public string[] _namedSort; // 0x18
        public System.Collections.IComparer _comparer; // 0x20
        public bool _eventsOwned; // 0x28
        public bool _needSort; // 0x29
        public bool _readOnly; // 0x2A
        public System.ComponentModel.EventDescriptorCollection Empty;
        public int _count; // 0x2C
        public object field_8; // 0x218

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877A37B0 | overloaded x3
        public void get_Count(){} // RVA: 0x7FFE81F84A50
        public void set_Count(){} // RVA: 0x7FFE82883A50
        public void get_Item(){} // RVA: 0x7FFE877A3A00 | overloaded x2
        public void Add(){} // RVA: 0x7FFE877A3A20
        public void Clear(){} // RVA: 0x7FFE877A3B00
        public void Contains(){} // RVA: 0x7FFE877A3B60
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE877A3BC0
        public void EnsureEventsOwned(){} // RVA: 0x7FFE877A3C10
        public void EnsureSize(){} // RVA: 0x7FFE877A3D10
        public void Find(){} // RVA: 0x7FFE877A3ED0
        public void IndexOf(){} // RVA: 0x7FFE877A40F0
        public void Insert(){} // RVA: 0x7FFE877A4150
        public void Remove(){} // RVA: 0x7FFE877A4250
        public void RemoveAt(){} // RVA: 0x7FFE877A4300
        public void GetEnumerator(){} // RVA: 0x7FFE877A43A0
        public void Sort(){} // RVA: 0x7FFE877A4660 | overloaded x4
        public void InternalSort(){} // RVA: 0x7FFE877A4B20 | overloaded x2
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE813240E0
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFE81F84A50
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE877A4C40
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE8755F0F0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE877A4D20
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE877A4EC0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE877A5000
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFE877A3B00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE877A50C0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE877A5180
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE877A52E0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFE877A53F0
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE82DEC5E0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE82DEC5E0
        public void .cctor(){} // RVA: 0x7FFE877A5400
    }

    public class EventHandlerList : Object
    {
        public ListEntry _head; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFE8778F950
        public void set_Item(){} // RVA: 0x7FFE8778F9C0
        public void AddHandler(){} // RVA: 0x7FFE8778FB20
        public void AddHandlers(){} // RVA: 0x7FFE8778FC90
        public void Dispose(){} // RVA: 0x7FFE86200400
        public void Find(){} // RVA: 0x7FFE8778FE40
        public void RemoveHandler(){} // RVA: 0x7FFE8778FE60
    }

    public class ExpandableObjectConverter : TypeConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void GetProperties(){} // RVA: 0x7FFE877A55C0
        public void GetPropertiesSupported(){} // RVA: 0x7FFE811E0850
    }

    public class ExtendedPropertyDescriptor : PropertyDescriptor
    {
        public System.ComponentModel.ReflectPropertyDescriptor _extenderInfo; // 0x88
        public System.ComponentModel.IExtenderProvider _provider; // 0x90
        public object field_2; // 0x222
        public object field_3; // 0x223

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877A59D0 | overloaded x2
        public void CanResetValue(){} // RVA: 0x7FFE877A5C20
        public void get_ComponentType(){} // RVA: 0x7FFE877A5C50
        public void get_IsReadOnly(){} // RVA: 0x7FFE877A5C80
        public void get_PropertyType(){} // RVA: 0x7FFE877A5DD0
        public void get_DisplayName(){} // RVA: 0x7FFE877A5E00
        public void GetValue(){} // RVA: 0x7FFE877A6050
        public void ResetValue(){} // RVA: 0x7FFE877A6080
        public void SetValue(){} // RVA: 0x7FFE877A60C0
        public void ShouldSerializeValue(){} // RVA: 0x7FFE877A6100
    }

    public class ExtenderProvidedPropertyAttribute : Attribute
    {
        public System.ComponentModel.PropertyDescriptor _extenderProperty; // 0x10
        public System.ComponentModel.IExtenderProvider _provider; // 0x18
        public System.Type _receiverType; // 0x20

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE877A6130
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_ExtenderProperty(){} // RVA: 0x7FFE81116380
        public void set_ExtenderProperty(){} // RVA: 0x7FFE810FCE30
        public void get_Provider(){} // RVA: 0x7FFE810FE7C0
        public void set_Provider(){} // RVA: 0x7FFE81161E80
        public void get_ReceiverType(){} // RVA: 0x7FFE811290C0
        public void set_ReceiverType(){} // RVA: 0x7FFE811290D0
        public void Equals(){} // RVA: 0x7FFE877A62A0
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void IsDefaultAttribute(){} // RVA: 0x7FFE877A63A0
    }

}