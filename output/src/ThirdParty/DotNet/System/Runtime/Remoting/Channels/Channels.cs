// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Channels
// Classes: 13
// Methods: 48

namespace ThirdParty.DotNet.System.Runtime.Remoting.Channels
{
    public class AsyncRequest : Object
    {
        public object ReplySink;
        public object MsgRequest;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xD5EFE0
    }

    public class CADSerializer : Object
    {
        // ── Methods ──
        public void DeserializeMessage(){} // RVA: 0x6767A00
        public void SerializeMessage(){} // RVA: 0x6767A40
        public void DeserializeObjectSafe(){} // RVA: 0x6767B80
        public void SerializeObject(){} // RVA: 0x6767CF0
        public void DeserializeObject(){} // RVA: 0x6767E30
    }

    public class ChannelServices : Object
    {
        public object registeredChannels;
        public object delayedClientChannels;
        public object _crossContextSink;
        public object CrossContextUrl;
        public object oldStartModeTypes;

        // ── Methods ──
        public void get_CrossContextChannel(){} // RVA: 0x67634B0
        public void CreateClientChannelSinkChain(){} // RVA: 0x6763B90
        public void RegisterChannel(){} // RVA: 0x6763D40
        public void RegisterChannelConfig(){} // RVA: 0x6764400
        public void CreateProvider(){} // RVA: 0x6765490
        public void SyncDispatchMessage(){} // RVA: 0x67657A0
        public void CheckIncomingMessage(){} // RVA: 0x6765870
        public void CheckReturnMessage(){} // RVA: 0x6765A90
        public void IsLocalCall(){} // RVA: 0xC2E4C0
        public void GetCurrentChannelInfo(){} // RVA: 0x6765C90
        public void .cctor(){} // RVA: 0x67660C0
    }

    public class CrossAppDomainChannel : Object
    {
        public object s_lock;

        // ── Methods ──
        public void RegisterCrossAppDomainChannel(){} // RVA: 0x67665C0
        public void get_ChannelName(){} // RVA: 0x6766780
        public void get_ChannelPriority(){} // RVA: 0x10ABBC0
        public void get_ChannelData(){} // RVA: 0x67667C0
        public void StartListening(){} // RVA: 0xB43310
        public void CreateMessageSink(){} // RVA: 0x6766820
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6766A10
    }

    public class CrossAppDomainData : Object
    {
        public object _ContextID;
        public object _DomainID;
        public object _processGuid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6766410
        public void get_DomainID(){} // RVA: 0xE62D00
        public void get_ProcessID(){} // RVA: 0xB700F0
    }

    public class CrossAppDomainSink : Object
    {
        public object s_sinks;
        public object processMessageMethod;
        public object _domainID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void GetSink(){} // RVA: 0x6766AC0
        public void get_TargetDomainId(){} // RVA: 0xB8F8F0
        public void ProcessMessageInDomain(){} // RVA: 0x6766E20
        public void SyncProcessMessage(){} // RVA: 0x6767240
        public void AsyncProcessMessage(){} // RVA: 0x67674A0
        public void SendAsyncMessage(){} // RVA: 0x6767610
        public void .cctor(){} // RVA: 0x67676D0
        public void <AsyncProcessMessage>b__10_0(){} // RVA: 0x6767930
    }

    public class IChannel
    {
        // ── Methods ──
        public void get_ChannelName(){} // RVA: 0x87C0A0
        public void get_ChannelPriority(){} // RVA: 0x87C130
    }

    public class IChannelReceiver
    {
        // ── Methods ──
        public void get_ChannelData(){} // RVA: 0x87C0A0
        public void StartListening(){} // RVA: 0x894320
    }

    public class IChannelSender
    {
        // ── Methods ──
        public void CreateMessageSink(){} // RVA: 0x882090
    }

    public class IClientChannelSinkProvider
    {
        // ── Methods ──
        public void set_Next(){} // RVA: 0x894320
    }

    public class ISecurableChannel
    {
        // ── Methods ──
        public void set_IsSecured(){} // RVA: 0x894750
    }

    public class IServerChannelSinkProvider
    {
        // ── Methods ──
        public void set_Next(){} // RVA: 0x894320
    }

    public class SinkProviderData : Object
    {
        public object sinkName;
        public object children;
        public object properties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6767F20
        public void get_Children(){} // RVA: 0xB465B0
        public void get_Properties(){} // RVA: 0xB700F0
    }

}