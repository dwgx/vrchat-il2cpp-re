// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 9
// Methods: 95

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class EditorAttribute : Attribute
    {
        public object _typeId;
        public object _editorBaseTypeName;
        public object _editorTypeName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76C22F0
        public void get_EditorBaseTypeName(){} // RVA: 0xB465B0
        public void get_EditorTypeName(){} // RVA: 0xB700F0
        public void get_TypeId(){} // RVA: 0x76C2400
        public void Equals(){} // RVA: 0x76C24F0
        public void GetHashCode(){} // RVA: 0x76ABD60
    }

    public class EditorBrowsableAttribute : Attribute
    {
        public object browsableState;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x132A2D0
        public void get_State(){} // RVA: 0xB8F8F0
        public void Equals(){} // RVA: 0x76AC080
        public void GetHashCode(){} // RVA: 0x76ABD60
    }

    public class EnumConverter : TypeConverter
    {
        public object values;
        public object type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xBA9BA0
        public void get_EnumType(){} // RVA: 0xB465B0
        public void get_Values(){} // RVA: 0xB5DBF0
        public void set_Values(){} // RVA: 0xB44D60
        public void CanConvertFrom(){} // RVA: 0x76E4B30
        public void CanConvertTo(){} // RVA: 0x76E4C50
        public void get_Comparer(){} // RVA: 0x76E4DC0
        public void ConvertFrom(){} // RVA: 0x76E4E20
        public void ConvertTo(){} // RVA: 0x76E52D0
        public void GetStandardValues(){} // RVA: 0x76E6300
        public void GetStandardValuesExclusive(){} // RVA: 0x76E6750
        public void GetStandardValuesSupported(){} // RVA: 0xC2E4C0
        public void IsValid(){} // RVA: 0x76E6810
    }

    public class EventDescriptor : MemberDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76C2630
        public void get_ComponentType(){} // RVA: 0x87C0A0
        public void get_EventType(){} // RVA: 0x87C0A0
        public void get_IsMulticast(){} // RVA: 0x87D280
        public void AddEventHandler(){} // RVA: 0x8943B0
        public void RemoveEventHandler(){} // RVA: 0x8943B0
    }

    public class EventDescriptorCollection : Object
    {
        public object _events;
        public object _namedSort;
        public object _comparer;
        public object _eventsOwned;
        public object _needSort;
        public object _readOnly;
        public object Empty;
        public object _count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76C2790
        public void get_Count(){} // RVA: 0x1AE5AC0
        public void set_Count(){} // RVA: 0x23E55F0
        public void get_Item(){} // RVA: 0x76C29E0
        public void Add(){} // RVA: 0x76C2A00
        public void Clear(){} // RVA: 0x76C2AE0
        public void Contains(){} // RVA: 0x76C2B40
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x76C2BA0
        public void EnsureEventsOwned(){} // RVA: 0x76C2BF0
        public void EnsureSize(){} // RVA: 0x76C2CF0
        public void Find(){} // RVA: 0x76C2EB0
        public void IndexOf(){} // RVA: 0x76C30F0
        public void Insert(){} // RVA: 0x76C3150
        public void Remove(){} // RVA: 0x76C3250
        public void RemoveAt(){} // RVA: 0x76C3300
        public void GetEnumerator(){} // RVA: 0x76C33A0
        public void Sort(){} // RVA: 0x76C3660
        public void InternalSort(){} // RVA: 0x76C3B50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xDAC980
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x1AE5AC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x76C3C70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7485660
        public void System.Collections.IList.set_Item(){} // RVA: 0x76C3D40
        public void System.Collections.IList.Add(){} // RVA: 0x76C3EE0
        public void System.Collections.IList.Contains(){} // RVA: 0x76C4020
        public void System.Collections.IList.Clear(){} // RVA: 0x76C2AE0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x76C40E0
        public void System.Collections.IList.Insert(){} // RVA: 0x76C41A0
        public void System.Collections.IList.Remove(){} // RVA: 0x76C4300
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x76C4410
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x28E58A0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x28E58A0
        public void .cctor(){} // RVA: 0x76C4420
    }

    public class EventHandlerList : Object
    {
        public object _head;
        public object _parent;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Item(){} // RVA: 0x76AF4E0
        public void set_Item(){} // RVA: 0x76AF550
        public void AddHandler(){} // RVA: 0x76AF6C0
        public void AddHandlers(){} // RVA: 0x76AF840
        public void Dispose(){} // RVA: 0x627C9E0
        public void Find(){} // RVA: 0x76AF9F0
        public void RemoveHandler(){} // RVA: 0x76AFA10
    }

    public class ExpandableObjectConverter : TypeConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void GetProperties(){} // RVA: 0x76C45E0
        public void GetPropertiesSupported(){} // RVA: 0xC2E4C0
    }

    public class ExtendedPropertyDescriptor : PropertyDescriptor
    {
        public object _extenderInfo;
        public object _provider;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76C49F0
        public void CanResetValue(){} // RVA: 0x76C4C10
        public void get_ComponentType(){} // RVA: 0x76C4C40
        public void get_IsReadOnly(){} // RVA: 0x76C4C70
        public void get_PropertyType(){} // RVA: 0x76C4D90
        public void get_DisplayName(){} // RVA: 0x76C4DC0
        public void GetValue(){} // RVA: 0x76C50D0
        public void ResetValue(){} // RVA: 0x76C5100
        public void SetValue(){} // RVA: 0x76C5140
        public void ShouldSerializeValue(){} // RVA: 0x76C5180
    }

    public class ExtenderProvidedPropertyAttribute : Attribute
    {
        public object _extenderProperty;
        public object _provider;
        public object _receiverType;

        // ── Methods ──
        public void Create(){} // RVA: 0x76C51B0
        public void .ctor(){} // RVA: 0xB43310
        public void get_ExtenderProperty(){} // RVA: 0xB5DBF0
        public void set_ExtenderProperty(){} // RVA: 0xB44D60
        public void get_Provider(){} // RVA: 0xB465B0
        public void set_Provider(){} // RVA: 0xBA9BA0
        public void get_ReceiverType(){} // RVA: 0xB700F0
        public void set_ReceiverType(){} // RVA: 0xB70100
        public void Equals(){} // RVA: 0x76C5320
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void IsDefaultAttribute(){} // RVA: 0x76C5420
    }

}