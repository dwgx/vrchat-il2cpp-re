// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Contexts
// Classes: 14
// Methods: 62

namespace ThirdParty.DotNet.System.Runtime.Remoting.Contexts
{
    public class Context : Object
    {
        // ── Methods ──
        public void RegisterContext(){} // RVA: 0x7ADAD4880
        public void ReleaseContext(){} // RVA: 0x7ADAD4890
        public void .ctor(){} // RVA: 0x7ADAD48A0
        public void Finalize(){} // RVA: 0x7ADAD4900
        public void get_DefaultContext(){} // RVA: 0x7ADAD4970
        public void get_ContextID(){} // RVA: 0x7A8668BC0
        public void get_ContextProperties(){} // RVA: 0x7ADAD49B0
        public void get_IsDefaultContext(){} // RVA: 0x7ADAD4A20
        public void get_NeedsContextSink(){} // RVA: 0x7ADAD4A30
        public void RegisterDynamicProperty(){} // RVA: 0x7ADAD4B20
        public void UnregisterDynamicProperty(){} // RVA: 0x7ADAD4D30
        public void GetDynamicPropertyCollection(){} // RVA: 0x7ADAD4F40
        public void NotifyGlobalDynamicSinks(){} // RVA: 0x7ADAD5100
        public void get_HasGlobalDynamicSinks(){} // RVA: 0x7ADAD5230
        public void NotifyDynamicSinks(){} // RVA: 0x7ADAD52E0
        public void get_HasDynamicSinks(){} // RVA: 0x7ADAD5380
        public void get_HasExitSinks(){} // RVA: 0x7ADAD53D0
        public void GetProperty(){} // RVA: 0x7ADAD54A0
        public void SetProperty(){} // RVA: 0x7ADAD5660
        public void Freeze(){} // RVA: 0x7ADAD5850
        public void ToString(){} // RVA: 0x7ADAD5A50
        public void GetServerContextSinkChain(){} // RVA: 0x7ADAD5AA0
        public void GetClientContextSinkChain(){} // RVA: 0x7ADAD5D30
        public void CreateServerObjectSinkChain(){} // RVA: 0x7ADAD5FB0
        public void CreateEnvoySink(){} // RVA: 0x7ADAD6270
        public void SwitchToContext(){} // RVA: 0x7ADAD6460
        public void CreateNewContext(){} // RVA: 0x7ADAD6470
        public void DoCallBack(){} // RVA: 0x7ADAD64F0
        public void get_MyLocalStore(){} // RVA: 0x7ADAD6650
        public void AllocateDataSlot(){} // RVA: 0x7ADAD6880
        public void AllocateNamedDataSlot(){} // RVA: 0x7ADAD68F0
        public void FreeNamedDataSlot(){} // RVA: 0x7ADAD6960
        public void GetNamedDataSlot(){} // RVA: 0x7ADAD69D0
        public void GetData(){} // RVA: 0x7ADAD6A40
        public void SetData(){} // RVA: 0x7ADAD6BB0
        public void .cctor(){} // RVA: 0x7ADAD6C30
    }

    public class ContextCallbackObject : ContextBoundObject
    {
        // ── Methods ──
        public void DoCallBack(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CrossContextChannel : Object
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x7ADAD7900
        public void AsyncProcessMessage(){} // RVA: 0x7ADAD7CA0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CrossContextDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8135E00
        public void Invoke(){} // RVA: 0x7A8135ED0
    }

    public class DynamicPropertyCollection : Object
    {
        // ── Methods ──
        public void get_HasProperties(){} // RVA: 0x7ADAD6D00
        public void RegisterDynamicProperty(){} // RVA: 0x7ADAD6D30
        public void UnregisterDynamicProperty(){} // RVA: 0x7ADAD70C0
        public void NotifyMessage(){} // RVA: 0x7ADAD7280
        public void FindProperty(){} // RVA: 0x7ADAD76F0
        public void .ctor(){} // RVA: 0x7ADAD7860
    }

    public class IContextAttribute
    {
        // ── Methods ──
        public void GetPropertiesForNewContext(){} // RVA: 0x7A7E18800
        public void IsContextOK(){} // RVA: 0x7A7E01A40
    }

    public class IContextProperty
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A7E00680
        public void Freeze(){} // RVA: 0x7A7E18800
        public void IsNewContextOK(){} // RVA: 0x7A7E019D0
    }

    public class IContributeClientContextSink
    {
        // ── Methods ──
        public void GetClientContextSink(){} // RVA: 0x7A7E00B20
    }

    public class IContributeDynamicSink
    {
        // ── Methods ──
        public void GetDynamicSink(){} // RVA: 0x7A7E00680
    }

    public class IContributeEnvoySink
    {
        // ── Methods ──
        public void GetEnvoySink(){} // RVA: 0x7A7E00BD0
    }

    public class IContributeObjectSink
    {
        // ── Methods ──
        public void GetObjectSink(){} // RVA: 0x7A7E00BD0
    }

    public class IContributeServerContextSink
    {
        // ── Methods ──
        public void GetServerContextSink(){} // RVA: 0x7A7E00B20
    }

    public class IDynamicMessageSink
    {
        // ── Methods ──
        public void ProcessMessageFinish(){} // RVA: 0x7A7E1E3B0
        public void ProcessMessageStart(){} // RVA: 0x7A7E1E3B0
    }

    public class IDynamicProperty
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A7E00680
    }

}