// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 11
// Methods: 80

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class AddingNewEventArgs : EventArgs
    {
        public object _newObject; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87790CE0 | overloaded x2
        public void get_NewObject(){} // RVA: 0x7FFE81116380
        public void set_NewObject(){} // RVA: 0x7FFE810FCE30
    }

    public class AddingNewEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE82886970
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class AmbientValueAttribute : Attribute
    {
        public object _value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x11
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void Equals(){} // RVA: 0x7FFE87791350
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
    }

    public class ArrayConverter : CollectionConverter
    {
        // ── Methods ──
        public void ConvertTo(){} // RVA: 0x7FFE87791400
        public void GetProperties(){} // RVA: 0x7FFE87791680
        public void GetPropertiesSupported(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ArraySubsetEnumerator : Object
    {
        public System.Array array; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877A54C0
        public void MoveNext(){} // RVA: 0x7FFE877A5530
        public void Reset(){} // RVA: 0x7FFE87677490
        public void get_Current(){} // RVA: 0x7FFE877C00B0
    }

    public class AsyncCompletedEventArgs : EventArgs
    {
        public System.Exception error; // 0x10
        public bool cancelled; // 0x18
        public object userState; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877C0170 | overloaded x2
        public void get_Cancelled(){} // RVA: 0x7FFE811164E0
        public void get_Error(){} // RVA: 0x7FFE81116380
        public void get_UserState(){} // RVA: 0x7FFE811290C0
        public void RaiseExceptionIfNecessary(){} // RVA: 0x7FFE877C0280
    }

    public class AsyncCompletedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE82886970
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class AsyncOperation : Object
    {
        public System.Threading.SynchronizationContext _syncContext; // 0x10
        public object _userSuppliedState; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8778CA30 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE8778C3A0
        public void get_UserSuppliedState(){} // RVA: 0x7FFE810FE7C0
        public void get_SynchronizationContext(){} // RVA: 0x7FFE81116380
        public void Post(){} // RVA: 0x7FFE8778C400
        public void PostOperationCompleted(){} // RVA: 0x7FFE8778C4F0
        public void OperationCompleted(){} // RVA: 0x7FFE8778C5F0
        public void PostCore(){} // RVA: 0x7FFE8778C660
        public void OperationCompletedCore(){} // RVA: 0x7FFE8778C750
        public void VerifyNotCompleted(){} // RVA: 0x7FFE8778C810
        public void VerifyDelegateNotNull(){} // RVA: 0x7FFE8778C880
        public void CreateOperation(){} // RVA: 0x7FFE8778C900
    }

    public class AsyncOperationManager : Object
    {
        // ── Methods ──
        public void CreateOperation(){} // RVA: 0x7FFE8778CA60
        public void get_SynchronizationContext(){} // RVA: 0x7FFE8778CBE0
        public void set_SynchronizationContext(){} // RVA: 0x7FFE8778CC40
    }

    public class AttributeCollection : Object
    {
        public System.ComponentModel.AttributeCollection Empty;
        public System.Collections.Hashtable s_defaultAttributes; // 0x8
        public System.Attribute[] _attributes; // 0x10
        public object s_internalSyncObject; // 0x10
        public int FOUND_TYPES_LIMIT;
        public AttributeEntry[] _foundAttributeTypes; // 0x18
        public int _index; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void FromExisting(){} // RVA: 0x7FFE87791DC0
        public void get_Attributes(){} // RVA: 0x7FFE81116380
        public void get_Count(){} // RVA: 0x7FFE87792180
        public void get_Item(){} // RVA: 0x7FFE877921F0 | overloaded x2
        public void Contains(){} // RVA: 0x7FFE877928C0 | overloaded x2
        public void GetDefaultAttribute(){} // RVA: 0x7FFE87792970
        public void GetEnumerator(){} // RVA: 0x7FFE87793020
        public void Matches(){} // RVA: 0x7FFE87793120 | overloaded x2
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE813240E0
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFE87792180
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE87793020
        public void CopyTo(){} // RVA: 0x7FFE87793220
        public void .cctor(){} // RVA: 0x7FFE877932B0
    }

    public class AttributeProviderAttribute : Attribute
    {
        public string _typeName; // 0x10
        public string _propertyName; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87793620 | overloaded x3
        public void get_TypeName(){} // RVA: 0x7FFE81116380
        public void get_PropertyName(){} // RVA: 0x7FFE810FE7C0
    }

}