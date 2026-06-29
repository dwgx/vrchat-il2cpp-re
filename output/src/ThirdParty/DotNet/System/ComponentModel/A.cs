// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 11
// Methods: 61

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class AddingNewEventArgs : EventArgs
    {
        public object _newObject;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76B0890
        public void get_NewObject(){} // RVA: 0xB5DBF0
        public void set_NewObject(){} // RVA: 0xB44D60
    }

    public class AddingNewEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x23E7ED0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class AmbientValueAttribute : Attribute
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Value(){} // RVA: 0xB5DBF0
        public void Equals(){} // RVA: 0x76B0A00
        public void GetHashCode(){} // RVA: 0x76ABD60
    }

    public class ArrayConverter : CollectionConverter
    {
        // ── Methods ──
        public void ConvertTo(){} // RVA: 0x76B0AB0
        public void GetProperties(){} // RVA: 0x76B0D30
        public void GetPropertiesSupported(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ArraySubsetEnumerator : Object
    {
        public object array;
        public object total;
        public object current;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76C44E0
        public void MoveNext(){} // RVA: 0x76C4550
        public void Reset(){} // RVA: 0x759C030
        public void get_Current(){} // RVA: 0x76DE5D0
    }

    public class AsyncCompletedEventArgs : EventArgs
    {
        public object error;
        public object cancelled;
        public object userState;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76DE690
        public void get_Cancelled(){} // RVA: 0xB5DD50
        public void get_Error(){} // RVA: 0xB5DBF0
        public void get_UserState(){} // RVA: 0xB700F0
        public void RaiseExceptionIfNecessary(){} // RVA: 0x76DE7A0
    }

    public class AsyncCompletedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x23E7ED0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class AsyncOperation : Object
    {
        public object _syncContext;
        public object _userSuppliedState;
        public object _alreadyCompleted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76AC870
        public void Finalize(){} // RVA: 0x76AC1E0
        public void get_UserSuppliedState(){} // RVA: 0xB465B0
        public void get_SynchronizationContext(){} // RVA: 0xB5DBF0
        public void Post(){} // RVA: 0x76AC240
        public void PostOperationCompleted(){} // RVA: 0x76AC330
        public void OperationCompleted(){} // RVA: 0x76AC430
        public void PostCore(){} // RVA: 0x76AC4A0
        public void OperationCompletedCore(){} // RVA: 0x76AC590
        public void VerifyNotCompleted(){} // RVA: 0x76AC650
        public void VerifyDelegateNotNull(){} // RVA: 0x76AC6C0
        public void CreateOperation(){} // RVA: 0x76AC740
    }

    public class AsyncOperationManager : Object
    {
        // ── Methods ──
        public void CreateOperation(){} // RVA: 0x76AC8A0
        public void get_SynchronizationContext(){} // RVA: 0x76ACA20
        public void set_SynchronizationContext(){} // RVA: 0x76ACA80
    }

    public class AttributeCollection : Object
    {
        public object Empty;
        public object s_defaultAttributes;
        public object _attributes;
        public object s_internalSyncObject;
        public object FOUND_TYPES_LIMIT;
        public object _foundAttributeTypes;
        public object _index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void FromExisting(){} // RVA: 0x76B1400
        public void get_Attributes(){} // RVA: 0xB5DBF0
        public void get_Count(){} // RVA: 0x76B17E0
        public void get_Item(){} // RVA: 0x76B1850
        public void Contains(){} // RVA: 0x76B1EE0
        public void GetDefaultAttribute(){} // RVA: 0x76B1FB0
        public void GetEnumerator(){} // RVA: 0x76B2630
        public void Matches(){} // RVA: 0x76B2740
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xDAC980
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x76B17E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x76B2630
        public void CopyTo(){} // RVA: 0x76B2840
        public void .cctor(){} // RVA: 0x76B28D0
    }

    public class AttributeProviderAttribute : Attribute
    {
        public object _typeName;
        public object _propertyName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76B2C40
        public void get_TypeName(){} // RVA: 0xB5DBF0
        public void get_PropertyName(){} // RVA: 0xB465B0
    }

}