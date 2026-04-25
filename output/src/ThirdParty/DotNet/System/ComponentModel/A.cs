// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 11
// Methods: 80

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class AddingNewEventArgs : EventArgs
    {
        public object NewObject; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93E85B0 | overloaded x2
        public void get_NewObject(){} // RVA: 0x7FFAC2F3C380
        public void set_NewObject(){} // RVA: 0x7FFAC2F22E30
    }

    public class AddingNewEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class AmbientValueAttribute : Attribute
    {
        public object Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x11
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void Equals(){} // RVA: 0x7FFAC93E8C20
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
    }

    public class ArrayConverter : CollectionConverter
    {
        // ── Methods ──
        public void ConvertTo(){} // RVA: 0x7FFAC93E8CD0
        public void GetProperties(){} // RVA: 0x7FFAC93E8F50
        public void GetPropertiesSupported(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ArraySubsetEnumerator : Object
    {
        public System.Array Current; // 0x10
        public int total; // 0x18
        public int current; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93FCD90
        public void MoveNext(){} // RVA: 0x7FFAC93FCE00
        public void Reset(){} // RVA: 0x7FFAC92CED60
        public void get_Current(){} // RVA: 0x7FFAC9417980
    }

    public class AsyncCompletedEventArgs : EventArgs
    {
        public System.Exception Cancelled; // 0x10
        public bool Error; // 0x18
        public object UserState; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9417A40 | overloaded x2
        public void get_Cancelled(){} // RVA: 0x7FFAC2F3C4E0
        public void get_Error(){} // RVA: 0x7FFAC2F3C380
        public void get_UserState(){} // RVA: 0x7FFAC2F4F0C0
        public void RaiseExceptionIfNecessary(){} // RVA: 0x7FFAC9417B50
    }

    public class AsyncCompletedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class AsyncOperation : Object
    {
        public System.Threading.SynchronizationContext UserSuppliedState; // 0x10
        public object SynchronizationContext; // 0x18
        public bool _alreadyCompleted; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93E4300 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC93E3C70
        public void get_UserSuppliedState(){} // RVA: 0x7FFAC2F247C0
        public void get_SynchronizationContext(){} // RVA: 0x7FFAC2F3C380
        public void Post(){} // RVA: 0x7FFAC93E3CD0
        public void PostOperationCompleted(){} // RVA: 0x7FFAC93E3DC0
        public void OperationCompleted(){} // RVA: 0x7FFAC93E3EC0
        public void PostCore(){} // RVA: 0x7FFAC93E3F30
        public void OperationCompletedCore(){} // RVA: 0x7FFAC93E4020
        public void VerifyNotCompleted(){} // RVA: 0x7FFAC93E40E0
        public void VerifyDelegateNotNull(){} // RVA: 0x7FFAC93E4150
        public void CreateOperation(){} // RVA: 0x7FFAC93E41D0
    }

    public class AsyncOperationManager : Object
    {
        public object SynchronizationContext;

        // ── Methods ──
        public void CreateOperation(){} // RVA: 0x7FFAC93E4330
        public void get_SynchronizationContext(){} // RVA: 0x7FFAC93E44B0
        public void set_SynchronizationContext(){} // RVA: 0x7FFAC93E4510
    }

    public class AttributeCollection : Object
    {
        public System.ComponentModel.AttributeCollection Attributes;
        public System.Collections.Hashtable Count; // 0x8
        public System.Attribute[] Item; // 0x10
        public object Item; // 0x10
        public int System.Collections.ICollection.IsSynchronized;
        public AttributeEntry[] System.Collections.ICollection.SyncRoot; // 0x18
        public int System.Collections.ICollection.Count; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void FromExisting(){} // RVA: 0x7FFAC93E9690
        public void get_Attributes(){} // RVA: 0x7FFAC2F3C380
        public void get_Count(){} // RVA: 0x7FFAC93E9A50
        public void get_Item(){} // RVA: 0x7FFAC93E9AC0 | overloaded x2
        public void Contains(){} // RVA: 0x7FFAC93EA190 | overloaded x2
        public void GetDefaultAttribute(){} // RVA: 0x7FFAC93EA240
        public void GetEnumerator(){} // RVA: 0x7FFAC93EA8F0
        public void Matches(){} // RVA: 0x7FFAC93EA9F0 | overloaded x2
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC34F9180
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFAC93E9A50
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC93EA8F0
        public void CopyTo(){} // RVA: 0x7FFAC93EAAF0
        public void .cctor(){} // RVA: 0x7FFAC93EAB80
    }

    public class AttributeProviderAttribute : Attribute
    {
        public string TypeName; // 0x10
        public string PropertyName; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93EAEF0 | overloaded x3
        public void get_TypeName(){} // RVA: 0x7FFAC2F3C380
        public void get_PropertyName(){} // RVA: 0x7FFAC2F247C0
    }

}