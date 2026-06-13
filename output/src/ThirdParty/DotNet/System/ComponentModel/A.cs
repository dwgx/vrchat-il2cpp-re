// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 11
// Methods: 80

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class AddingNewEventArgs
    {
        public object <NewObject>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C4FE30 | overloaded x2
        public void get_NewObject(){} // RVA: 0x2F8380
        public void set_NewObject(){} // RVA: 0x2DEE30
    }

    public class AddingNewEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
        public void BeginInvoke(){} // RVA: 0x1AFE3C0
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class AmbientValueAttribute
    {
        public object <Value>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x11
        public void get_Value(){} // RVA: 0x2F8380
        public void Equals(){} // RVA: 0x6C504A0
        public void GetHashCode(){} // RVA: 0x6C4B080
    }

    public class ArrayConverter
    {
        // ── Methods ──
        public void ConvertTo(){} // RVA: 0x6C50550
        public void GetProperties(){} // RVA: 0x6C507D0
        public void GetPropertiesSupported(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ArraySubsetEnumerator
    {
        public System.Array array; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C64610
        public void MoveNext(){} // RVA: 0x6C64680
        public void Reset(){} // RVA: 0x6B381E0
        public void get_Current(){} // RVA: 0x6C7F200
    }

    public class AsyncCompletedEventArgs
    {
        public System.Exception error; // 0x10
        public bool cancelled; // 0x18
        public object userState; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C7F2C0 | overloaded x2
        public void get_Cancelled(){} // RVA: 0x2F84E0
        public void get_Error(){} // RVA: 0x2F8380
        public void get_UserState(){} // RVA: 0x30B0C0
        public void RaiseExceptionIfNecessary(){} // RVA: 0x6C7F3D0
    }

    public class AsyncCompletedEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
        public void BeginInvoke(){} // RVA: 0x1AFE3C0
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class AsyncOperation
    {
        public System.Threading.SynchronizationContext SynchronizationContext; // 0x10
        public object _userSuppliedState; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C4BB80 | overloaded x2
        public void Finalize(){} // RVA: 0x6C4B4F0
        public void get_UserSuppliedState(){} // RVA: 0x2E07C0
        public void get_SynchronizationContext(){} // RVA: 0x2F8380
        public void Post(){} // RVA: 0x6C4B550
        public void PostOperationCompleted(){} // RVA: 0x6C4B640
        public void OperationCompleted(){} // RVA: 0x6C4B740
        public void PostCore(){} // RVA: 0x6C4B7B0
        public void OperationCompletedCore(){} // RVA: 0x6C4B8A0
        public void VerifyNotCompleted(){} // RVA: 0x6C4B960
        public void VerifyDelegateNotNull(){} // RVA: 0x6C4B9D0
        public void CreateOperation(){} // RVA: 0x6C4BA50
    }

    public class AsyncOperationManager
    {
        public object CancellationPending;

        // ── Methods ──
        public void CreateOperation(){} // RVA: 0x6C4BBB0
        public void get_SynchronizationContext(){} // RVA: 0x6C4BD30
        public void set_SynchronizationContext(){} // RVA: 0x6C4BD90
    }

    public class AttributeCollection
    {
        public System.ComponentModel.AttributeCollection Empty;
        public System.Collections.Hashtable s_defaultAttributes; // 0x8
        public System.Attribute[] _attributes; // 0x10
        public object s_internalSyncObject; // 0x10
        public int FOUND_TYPES_LIMIT;
        public AttributeEntry[] _foundAttributeTypes; // 0x18
        public int _index; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310 | overloaded x2
        public void FromExisting(){} // RVA: 0x6C50F10
        public void get_Attributes(){} // RVA: 0x2F8380
        public void get_Count(){} // RVA: 0x6C512D0
        public void get_Item(){} // RVA: 0x6C51340 | overloaded x2
        public void Contains(){} // RVA: 0x6C51A10 | overloaded x2
        public void GetDefaultAttribute(){} // RVA: 0x6C51AC0
        public void GetEnumerator(){} // RVA: 0x6C52170
        public void Matches(){} // RVA: 0x6C52270 | overloaded x2
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x519240
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x6C512D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6C52170
        public void CopyTo(){} // RVA: 0x6C52370
        public void .cctor(){} // RVA: 0x6C52400
    }

    public class AttributeProviderAttribute
    {
        public string <TypeName>k__BackingField; // 0x10
        public string <PropertyName>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C52770 | overloaded x3
        public void get_TypeName(){} // RVA: 0x2F8380
        public void get_PropertyName(){} // RVA: 0x2E07C0
    }

}