// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Channels
// Classes: 14
// Methods: 50

namespace ThirdParty.DotNet.System.Runtime.Remoting.Channels
{
    public class AsyncRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2F7F2A0
    }

    public class CADSerializer
    {
        // ── Methods ──
        public void DeserializeMessage(){} // RVA: 0x7FFAF879F0D0
        public void SerializeMessage(){} // RVA: 0x7FFAF879F110
        public void DeserializeObjectSafe(){} // RVA: 0x7FFAF879F250
        public void SerializeObject(){} // RVA: 0x7FFAF879F3C0
        public void DeserializeObject(){} // RVA: 0x7FFAF879F500
    }

    public class ChannelServices
    {
        public object DomainID;

        // ── Methods ──
        public void get_CrossContextChannel(){} // RVA: 0x7FFAF879A830
        public void CreateClientChannelSinkChain(){} // RVA: 0x7FFAF879AF80 | overloaded x2
        public void RegisterChannel(){} // RVA: 0x7FFAF879B130 | overloaded x2
        public void RegisterChannelConfig(){} // RVA: 0x7FFAF879B820
        public void CreateProvider(){} // RVA: 0x7FFAF879CA30
        public void SyncDispatchMessage(){} // RVA: 0x7FFAF879CD50
        public void CheckIncomingMessage(){} // RVA: 0x7FFAF879CE20
        public void CheckReturnMessage(){} // RVA: 0x7FFAF879D050
        public void IsLocalCall(){} // RVA: 0x7FFAF2E72850
        public void GetCurrentChannelInfo(){} // RVA: 0x7FFAF879D250
        public void .cctor(){} // RVA: 0x7FFAF879D6C0
    }

    public class CrossAppDomainChannel
    {
        // ── Methods ──
        public void RegisterCrossAppDomainChannel(){} // RVA: 0x7FFAF879DBD0
        public void get_ChannelName(){} // RVA: 0x7FFAF879DDC0
        public void get_ChannelPriority(){} // RVA: 0x7FFAF32A0090
        public void get_ChannelData(){} // RVA: 0x7FFAF879DE00
        public void StartListening(){} // RVA: 0x7FFAF2D8D310
        public void CreateMessageSink(){} // RVA: 0x7FFAF879DE60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF879E050
    }

    public class CrossAppDomainData
    {
        public object ChannelName;
        public object ChannelPriority;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF879DA10
        public void get_DomainID(){} // RVA: 0x7FFAF306ED50
        public void get_ProcessID(){} // RVA: 0x7FFAF2DBB0C0
    }

    public class CrossAppDomainSink
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
        public void GetSink(){} // RVA: 0x7FFAF879E100
        public void get_TargetDomainId(){} // RVA: 0x7FFAF2DDA5C0
        public void ProcessMessageInDomain(){} // RVA: 0x7FFAF879E4C0
        public void SyncProcessMessage(){} // RVA: 0x7FFAF879E8E0
        public void AsyncProcessMessage(){} // RVA: 0x7FFAF879EB40
        public void SendAsyncMessage(){} // RVA: 0x7FFAF879ECB0
        public void .cctor(){} // RVA: 0x7FFAF879ED70
        public void <AsyncProcessMessage>b__10_0(){} // RVA: 0x7FFAF879F000
    }

    public class IChannel
    {
        // ── Methods ──
        public void get_ChannelName(){} // RVA: 0x7FFAF2ABCD60
        public void get_ChannelPriority(){} // RVA: 0x7FFAF2ABD840
    }

    public class IChannelDataStore
    {
    }

    public class IChannelReceiver : {$D
    {
        // ── Methods ──
        public void get_ChannelData(){} // RVA: 0x7FFAF2ABCD60
        public void StartListening(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IChannelSender
    {
        // ── Methods ──
        public void CreateMessageSink(){} // RVA: 0x7FFAF2ACEE30
    }

    public class IClientChannelSinkProvider
    {
        // ── Methods ──
        public void set_Next(){} // RVA: 0x7FFAF2AD4B10
    }

    public class ISecurableChannel
    {
        // ── Methods ──
        public void set_IsSecured(){} // RVA: 0x7FFAF2AD5130
    }

    public class IServerChannelSinkProvider
    {
        // ── Methods ──
        public void set_Next(){} // RVA: 0x7FFAF2AD4B10
    }

    public class SinkProviderData
    {
        public object ConstructionActivator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF879F5F0
        public void get_Children(){} // RVA: 0x7FFAF2D907C0
        public void get_Properties(){} // RVA: 0x7FFAF2DBB0C0
    }

}