// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Contexts
// Classes: 14
// Methods: 62

namespace ThirdParty.DotNet.System.Runtime.Remoting.Contexts
{
    public class Context : Object
    {
        public int DefaultContext; // 0x10
        public int ContextID; // 0x14
        public object ContextProperties; // 0x18
        public object IsDefaultContext; // 0x20
        public object[] NeedsContextSink;
        public System.Runtime.Remoting.Messaging.IMessageSink HasGlobalDynamicSinks; // 0x8
        public System.Runtime.Remoting.Messaging.IMessageSink HasDynamicSinks; // 0x28
        public System.Runtime.Remoting.Messaging.IMessageSink HasExitSinks; // 0x30
        public System.Collections.Generic.List`1<System.Runtime.Remoting.Contexts.IContextProperty> MyLocalStore; // 0x38
        public int global_count; // 0x10
        public System.LocalDataStoreHolder _localDataStore; // 0x40
        public System.LocalDataStoreMgr _localDataStoreMgr; // 0x18
        public System.Runtime.Remoting.Contexts.DynamicPropertyCollection global_dynamic_properties; // 0x20
        public System.Runtime.Remoting.Contexts.DynamicPropertyCollection context_dynamic_properties; // 0x48
        public System.Runtime.Remoting.Contexts.ContextCallbackObject callback_object; // 0x50

        // ── Methods ──
        public void RegisterContext(){} // RVA: 0x7FFAC847E240
        public void ReleaseContext(){} // RVA: 0x7FFAC847E250
        public void .ctor(){} // RVA: 0x7FFAC847E260
        public void Finalize(){} // RVA: 0x7FFAC847E2C0
        public void get_DefaultContext(){} // RVA: 0x7FFAC847E330
        public void get_ContextID(){} // RVA: 0x7FFAC33D5A20
        public void get_ContextProperties(){} // RVA: 0x7FFAC847E370
        public void get_IsDefaultContext(){} // RVA: 0x7FFAC847E3E0
        public void get_NeedsContextSink(){} // RVA: 0x7FFAC847E3F0
        public void RegisterDynamicProperty(){} // RVA: 0x7FFAC847E4E0
        public void UnregisterDynamicProperty(){} // RVA: 0x7FFAC847E6F0
        public void GetDynamicPropertyCollection(){} // RVA: 0x7FFAC847E900
        public void NotifyGlobalDynamicSinks(){} // RVA: 0x7FFAC847EAC0
        public void get_HasGlobalDynamicSinks(){} // RVA: 0x7FFAC847EBF0
        public void NotifyDynamicSinks(){} // RVA: 0x7FFAC847ECA0
        public void get_HasDynamicSinks(){} // RVA: 0x7FFAC847ED40
        public void get_HasExitSinks(){} // RVA: 0x7FFAC847ED90
        public void GetProperty(){} // RVA: 0x7FFAC847EE60
        public void SetProperty(){} // RVA: 0x7FFAC847F020
        public void Freeze(){} // RVA: 0x7FFAC847F210
        public void ToString(){} // RVA: 0x7FFAC847F410
        public void GetServerContextSinkChain(){} // RVA: 0x7FFAC847F460
        public void GetClientContextSinkChain(){} // RVA: 0x7FFAC847F6C0
        public void CreateServerObjectSinkChain(){} // RVA: 0x7FFAC847F930
        public void CreateEnvoySink(){} // RVA: 0x7FFAC847FBD0
        public void SwitchToContext(){} // RVA: 0x7FFAC847FDB0
        public void CreateNewContext(){} // RVA: 0x7FFAC847FDC0
        public void DoCallBack(){} // RVA: 0x7FFAC847FE40
        public void get_MyLocalStore(){} // RVA: 0x7FFAC847FFE0
        public void AllocateDataSlot(){} // RVA: 0x7FFAC8480240
        public void AllocateNamedDataSlot(){} // RVA: 0x7FFAC84802B0
        public void FreeNamedDataSlot(){} // RVA: 0x7FFAC8480320
        public void GetNamedDataSlot(){} // RVA: 0x7FFAC8480390
        public void GetData(){} // RVA: 0x7FFAC8480400
        public void SetData(){} // RVA: 0x7FFAC8480570
        public void .cctor(){} // RVA: 0x7FFAC84805F0
    }

    public class ContextCallbackObject : ContextBoundObject
    {
        // ── Methods ──
        public void DoCallBack(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CrossContextChannel : Object
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x7FFAC8481360
        public void AsyncProcessMessage(){} // RVA: 0x7FFAC8481700
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CrossContextDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F7F980
        public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    }

    public class DynamicPropertyCollection : Object
    {
        public System.Collections.ArrayList HasProperties; // 0x10

        // ── Methods ──
        public void get_HasProperties(){} // RVA: 0x7FFAC84806C0
        public void RegisterDynamicProperty(){} // RVA: 0x7FFAC84806F0
        public void UnregisterDynamicProperty(){} // RVA: 0x7FFAC8480AC0
        public void NotifyMessage(){} // RVA: 0x7FFAC8480CC0
        public void FindProperty(){} // RVA: 0x7FFAC8481160
        public void .ctor(){} // RVA: 0x7FFAC84812C0
    }

    public class IContextAttribute
    {
        // ── Methods ──
        public void GetPropertiesForNewContext(){} // RVA: 0x7FFAC2C70A40
        public void IsContextOK(){} // RVA: 0x7FFAC2C5D200
    }

    public class IContextProperty
    {
        public object Name;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void Freeze(){} // RVA: 0x7FFAC2C70A40
        public void IsNewContextOK(){} // RVA: 0x7FFAC2C59F60
    }

    public class IContributeClientContextSink
    {
        // ── Methods ──
        public void GetClientContextSink(){} // RVA: 0x7FFAC2C58F40
    }

    public class IContributeDynamicSink
    {
        // ── Methods ──
        public void GetDynamicSink(){} // RVA: 0x7FFAC2C58E90
    }

    public class IContributeEnvoySink
    {
        // ── Methods ──
        public void GetEnvoySink(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class IContributeObjectSink
    {
        // ── Methods ──
        public void GetObjectSink(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class IContributeServerContextSink
    {
        // ── Methods ──
        public void GetServerContextSink(){} // RVA: 0x7FFAC2C58F40
    }

    public class IDynamicMessageSink
    {
        // ── Methods ──
        public void ProcessMessageFinish(){} // RVA: 0x7FFAC2C76590
        public void ProcessMessageStart(){} // RVA: 0x7FFAC2C76590
    }

    public class IDynamicProperty
    {
        public object Name;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
    }

}