// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Contexts
// Classes: 14
// Methods: 62

namespace ThirdParty.DotNet.System.Runtime.Remoting.Contexts
{
    public class Context : Object
    {
        public int domain_id; // 0x10
        public int context_id; // 0x14
        public object static_data; // 0x18
        public object data; // 0x20
        public object[] local_slots;
        public System.Runtime.Remoting.Messaging.IMessageSink default_server_context_sink; // 0x8
        public System.Runtime.Remoting.Messaging.IMessageSink server_context_sink_chain; // 0x28
        public System.Runtime.Remoting.Messaging.IMessageSink client_context_sink_chain; // 0x30
        public System.Collections.Generic.List`1<System.Runtime.Remoting.Contexts.IContextProperty> context_properties; // 0x38

        // ── Methods ──
        public void RegisterContext(){} // RVA: 0x7FFE86827B50
        public void ReleaseContext(){} // RVA: 0x7FFE86827B60
        public void .ctor(){} // RVA: 0x7FFE86827B70
        public void Finalize(){} // RVA: 0x7FFE86827BD0
        public void get_DefaultContext(){} // RVA: 0x7FFE86827C40
        public void get_ContextID(){} // RVA: 0x7FFE8164B230
        public void get_ContextProperties(){} // RVA: 0x7FFE86827C80
        public void get_IsDefaultContext(){} // RVA: 0x7FFE86827CF0
        public void get_NeedsContextSink(){} // RVA: 0x7FFE86827D00
        public void RegisterDynamicProperty(){} // RVA: 0x7FFE86827DF0
        public void UnregisterDynamicProperty(){} // RVA: 0x7FFE86828000
        public void GetDynamicPropertyCollection(){} // RVA: 0x7FFE86828210
        public void NotifyGlobalDynamicSinks(){} // RVA: 0x7FFE868283D0
        public void get_HasGlobalDynamicSinks(){} // RVA: 0x7FFE86828500
        public void NotifyDynamicSinks(){} // RVA: 0x7FFE868285B0
        public void get_HasDynamicSinks(){} // RVA: 0x7FFE86828650
        public void get_HasExitSinks(){} // RVA: 0x7FFE868286A0
        public void GetProperty(){} // RVA: 0x7FFE86828770
        public void SetProperty(){} // RVA: 0x7FFE86828930
        public void Freeze(){} // RVA: 0x7FFE86828B20
        public void ToString(){} // RVA: 0x7FFE86828D20
        public void GetServerContextSinkChain(){} // RVA: 0x7FFE86828D70
        public void GetClientContextSinkChain(){} // RVA: 0x7FFE86828FD0
        public void CreateServerObjectSinkChain(){} // RVA: 0x7FFE86829240
        public void CreateEnvoySink(){} // RVA: 0x7FFE868294E0
        public void SwitchToContext(){} // RVA: 0x7FFE868296C0
        public void CreateNewContext(){} // RVA: 0x7FFE868296D0
        public void DoCallBack(){} // RVA: 0x7FFE86829750
        public void get_MyLocalStore(){} // RVA: 0x7FFE868298F0
        public void AllocateDataSlot(){} // RVA: 0x7FFE86829B50
        public void AllocateNamedDataSlot(){} // RVA: 0x7FFE86829BC0
        public void FreeNamedDataSlot(){} // RVA: 0x7FFE86829C30
        public void GetNamedDataSlot(){} // RVA: 0x7FFE86829CA0
        public void GetData(){} // RVA: 0x7FFE86829D10
        public void SetData(){} // RVA: 0x7FFE86829E80
        public void .cctor(){} // RVA: 0x7FFE86829F00
    }

    public class ContextCallbackObject : ContextBoundObject
    {
        // ── Methods ──
        public void DoCallBack(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CrossContextChannel : Object
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x7FFE8682AC70
        public void AsyncProcessMessage(){} // RVA: 0x7FFE8682B010
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CrossContextDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81159980
        public void Invoke(){} // RVA: 0x7FFE81159A50
    }

    public class DynamicPropertyCollection : Object
    {
        public System.Collections.ArrayList _properties; // 0x10

        // ── Methods ──
        public void get_HasProperties(){} // RVA: 0x7FFE86829FD0
        public void RegisterDynamicProperty(){} // RVA: 0x7FFE8682A000
        public void UnregisterDynamicProperty(){} // RVA: 0x7FFE8682A3D0
        public void NotifyMessage(){} // RVA: 0x7FFE8682A5D0
        public void FindProperty(){} // RVA: 0x7FFE8682AA70
        public void .ctor(){} // RVA: 0x7FFE8682ABD0
    }

    public class IContextAttribute
    {
        // ── Methods ──
        public void GetPropertiesForNewContext(){} // RVA: 0x7FFE80E460A0
        public void IsContextOK(){} // RVA: 0x7FFE80E32650
    }

    public class IContextProperty
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void Freeze(){} // RVA: 0x7FFE80E460A0
        public void IsNewContextOK(){} // RVA: 0x7FFE80E2F3B0
    }

    public class IContributeClientContextSink
    {
        // ── Methods ──
        public void GetClientContextSink(){} // RVA: 0x7FFE80E2E390
    }

    public class IContributeDynamicSink
    {
        // ── Methods ──
        public void GetDynamicSink(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IContributeEnvoySink
    {
        // ── Methods ──
        public void GetEnvoySink(){} // RVA: 0x7FFE80E3FC10
    }

    public class IContributeObjectSink
    {
        // ── Methods ──
        public void GetObjectSink(){} // RVA: 0x7FFE80E3FC10
    }

    public class IContributeServerContextSink
    {
        // ── Methods ──
        public void GetServerContextSink(){} // RVA: 0x7FFE80E2E390
    }

    public class IDynamicMessageSink
    {
        // ── Methods ──
        public void ProcessMessageFinish(){} // RVA: 0x7FFE80E4BC90
        public void ProcessMessageStart(){} // RVA: 0x7FFE80E4BC90
    }

    public class IDynamicProperty
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
    }

}