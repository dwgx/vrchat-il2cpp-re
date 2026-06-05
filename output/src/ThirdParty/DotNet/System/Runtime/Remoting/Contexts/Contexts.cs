// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Contexts
// Classes: 14
// Methods: 62

namespace ThirdParty.DotNet.System.Runtime.Remoting.Contexts
{
    public class Context
    {
        // ── Methods ──
        public void RegisterContext(){} // RVA: 0x7FFAF8796C50
        public void ReleaseContext(){} // RVA: 0x7FFAF8796C60
        public void .ctor(){} // RVA: 0x7FFAF8796C70
        public void Finalize(){} // RVA: 0x7FFAF8796CD0
        public void get_DefaultContext(){} // RVA: 0x7FFAF8796D40
        public void get_ContextID(){} // RVA: 0x7FFAF335BED0
        public void get_ContextProperties(){} // RVA: 0x7FFAF8796D80
        public void get_IsDefaultContext(){} // RVA: 0x7FFAF8796DF0
        public void get_NeedsContextSink(){} // RVA: 0x7FFAF8796E00
        public void RegisterDynamicProperty(){} // RVA: 0x7FFAF8796EF0
        public void UnregisterDynamicProperty(){} // RVA: 0x7FFAF8797100
        public void GetDynamicPropertyCollection(){} // RVA: 0x7FFAF8797310
        public void NotifyGlobalDynamicSinks(){} // RVA: 0x7FFAF87974D0
        public void get_HasGlobalDynamicSinks(){} // RVA: 0x7FFAF8797600
        public void NotifyDynamicSinks(){} // RVA: 0x7FFAF87976B0
        public void get_HasDynamicSinks(){} // RVA: 0x7FFAF8797750
        public void get_HasExitSinks(){} // RVA: 0x7FFAF87977A0
        public void GetProperty(){} // RVA: 0x7FFAF8797870
        public void SetProperty(){} // RVA: 0x7FFAF8797A30
        public void Freeze(){} // RVA: 0x7FFAF8797C20
        public void ToString(){} // RVA: 0x7FFAF8797E20
        public void GetServerContextSinkChain(){} // RVA: 0x7FFAF8797E70
        public void GetClientContextSinkChain(){} // RVA: 0x7FFAF87980D0
        public void CreateServerObjectSinkChain(){} // RVA: 0x7FFAF8798340
        public void CreateEnvoySink(){} // RVA: 0x7FFAF87985E0
        public void SwitchToContext(){} // RVA: 0x7FFAF87987C0
        public void CreateNewContext(){} // RVA: 0x7FFAF87987D0
        public void DoCallBack(){} // RVA: 0x7FFAF8798850
        public void get_MyLocalStore(){} // RVA: 0x7FFAF87989F0
        public void AllocateDataSlot(){} // RVA: 0x7FFAF8798C50
        public void AllocateNamedDataSlot(){} // RVA: 0x7FFAF8798CC0
        public void FreeNamedDataSlot(){} // RVA: 0x7FFAF8798D30
        public void GetNamedDataSlot(){} // RVA: 0x7FFAF8798DA0
        public void GetData(){} // RVA: 0x7FFAF8798E10
        public void SetData(){} // RVA: 0x7FFAF8798F80
        public void .cctor(){} // RVA: 0x7FFAF8799000
    }

    public class ContextCallbackObject
    {
        // ── Methods ──
        public void DoCallBack(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CrossContextChannel
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x7FFAF8799D70
        public void AsyncProcessMessage(){} // RVA: 0x7FFAF879A110
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CrossContextDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DEB980
        public void Invoke(){} // RVA: 0x7FFAF2DEBA50
    }

    public class DynamicPropertyCollection
    {
        // ── Methods ──
        public void get_HasProperties(){} // RVA: 0x7FFAF87990D0
        public void RegisterDynamicProperty(){} // RVA: 0x7FFAF8799100
        public void UnregisterDynamicProperty(){} // RVA: 0x7FFAF87994D0
        public void NotifyMessage(){} // RVA: 0x7FFAF87996D0
        public void FindProperty(){} // RVA: 0x7FFAF8799B70
        public void .ctor(){} // RVA: 0x7FFAF8799CD0
    }

    public class IContextAttribute
    {
        // ── Methods ──
        public void GetPropertiesForNewContext(){} // RVA: 0x7FFAF2AD4B10
        public void IsContextOK(){} // RVA: 0x7FFAF2AC1120
    }

    public class IContextProperty
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2ABCD60
        public void Freeze(){} // RVA: 0x7FFAF2AD4B10
        public void IsNewContextOK(){} // RVA: 0x7FFAF2ABDE40
    }

    public class IContributeClientContextSink
    {
        // ── Methods ──
        public void GetClientContextSink(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IContributeDynamicSink
    {
        // ── Methods ──
        public void GetDynamicSink(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IContributeEnvoySink
    {
        // ── Methods ──
        public void GetEnvoySink(){} // RVA: 0x7FFAF2ACE6A0
    }

    public class IContributeObjectSink
    {
        // ── Methods ──
        public void GetObjectSink(){} // RVA: 0x7FFAF2ACE6A0
    }

    public class IContributeServerContextSink
    {
        // ── Methods ──
        public void GetServerContextSink(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IDynamicMessageSink
    {
        // ── Methods ──
        public void ProcessMessageFinish(){} // RVA: 0x7FFAF2ADA6B0
        public void ProcessMessageStart(){} // RVA: 0x7FFAF2ADA6B0
    }

    public class IDynamicProperty
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2ABCD60
    }

}