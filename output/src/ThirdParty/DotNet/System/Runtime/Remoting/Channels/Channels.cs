// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Channels
// Classes: 14
// Methods: 50

namespace ThirdParty.DotNet.System.Runtime.Remoting.Channels
{
    public class AsyncRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4CF2A0
    }

    public class CADSerializer
    {
        // ── Methods ──
        public void DeserializeMessage(){} // RVA: 0x5CEF0D0
        public void SerializeMessage(){} // RVA: 0x5CEF110
        public void DeserializeObjectSafe(){} // RVA: 0x5CEF250
        public void SerializeObject(){} // RVA: 0x5CEF3C0
        public void DeserializeObject(){} // RVA: 0x5CEF500
    }

    public class ChannelServices
    {
        public object DomainID;

        // ── Methods ──
        public void get_CrossContextChannel(){} // RVA: 0x5CEA830
        public void CreateClientChannelSinkChain(){} // RVA: 0x5CEAF80 | overloaded x2
        public void RegisterChannel(){} // RVA: 0x5CEB130 | overloaded x2
        public void RegisterChannelConfig(){} // RVA: 0x5CEB820
        public void CreateProvider(){} // RVA: 0x5CECA30
        public void SyncDispatchMessage(){} // RVA: 0x5CECD50
        public void CheckIncomingMessage(){} // RVA: 0x5CECE20
        public void CheckReturnMessage(){} // RVA: 0x5CED050
        public void IsLocalCall(){} // RVA: 0x3C2850
        public void GetCurrentChannelInfo(){} // RVA: 0x5CED250
        public void .cctor(){} // RVA: 0x5CED6C0
    }

    public class CrossAppDomainChannel
    {
        // ── Methods ──
        public void RegisterCrossAppDomainChannel(){} // RVA: 0x5CEDBD0
        public void get_ChannelName(){} // RVA: 0x5CEDDC0
        public void get_ChannelPriority(){} // RVA: 0x7F0090
        public void get_ChannelData(){} // RVA: 0x5CEDE00
        public void StartListening(){} // RVA: 0x2DD310
        public void CreateMessageSink(){} // RVA: 0x5CEDE60
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x5CEE050
    }

    public class CrossAppDomainData
    {
        public object ChannelName;
        public object ChannelPriority;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CEDA10
        public void get_DomainID(){} // RVA: 0x5BED50
        public void get_ProcessID(){} // RVA: 0x30B0C0
    }

    public class CrossAppDomainSink
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void GetSink(){} // RVA: 0x5CEE100
        public void get_TargetDomainId(){} // RVA: 0x32A5C0
        public void ProcessMessageInDomain(){} // RVA: 0x5CEE4C0
        public void SyncProcessMessage(){} // RVA: 0x5CEE8E0
        public void AsyncProcessMessage(){} // RVA: 0x5CEEB40
        public void SendAsyncMessage(){} // RVA: 0x5CEECB0
        public void .cctor(){} // RVA: 0x5CEED70
        public void <AsyncProcessMessage>b__10_0(){} // RVA: 0x5CEF000
    }

    public class IChannel
    {
        // ── Methods ──
        public void get_ChannelName(){} // RVA: 0xCD60
        public void get_ChannelPriority(){} // RVA: 0xD840
    }

    public class IChannelDataStore
    {
    }

    public class IChannelReceiver : {$D
    {
        // ── Methods ──
        public void get_ChannelData(){} // RVA: 0xCD60
        public void StartListening(){} // RVA: 0x24B10
    }

    public class IChannelSender
    {
        // ── Methods ──
        public void CreateMessageSink(){} // RVA: 0x1EE30
    }

    public class IClientChannelSinkProvider
    {
        // ── Methods ──
        public void set_Next(){} // RVA: 0x24B10
    }

    public class ISecurableChannel
    {
        // ── Methods ──
        public void set_IsSecured(){} // RVA: 0x25130
    }

    public class IServerChannelSinkProvider
    {
        // ── Methods ──
        public void set_Next(){} // RVA: 0x24B10
    }

    public class SinkProviderData
    {
        public object ConstructionActivator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CEF5F0
        public void get_Children(){} // RVA: 0x2E07C0
        public void get_Properties(){} // RVA: 0x30B0C0
    }

}