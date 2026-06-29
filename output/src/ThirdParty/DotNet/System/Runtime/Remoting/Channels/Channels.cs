// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Channels
// Classes: 13
// Methods: 48

namespace ThirdParty.DotNet.System.Runtime.Remoting.Channels
{
    public class AsyncRequest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9A41AA0
    }

    public class CADSerializer : Object
    {
        // ── Methods ──
        public void DeserializeMessage(){} // RVA: 0x7ADADCAD0
        public void SerializeMessage(){} // RVA: 0x7ADADCB10
        public void DeserializeObjectSafe(){} // RVA: 0x7ADADCC50
        public void SerializeObject(){} // RVA: 0x7ADADCDC0
        public void DeserializeObject(){} // RVA: 0x7ADADCF00
    }

    public class ChannelServices : Object
    {
        // ── Methods ──
        public void get_CrossContextChannel(){} // RVA: 0x7ADAD83D0
        public void CreateClientChannelSinkChain(){} // RVA: 0x7ADAD8AB0
        public void RegisterChannel(){} // RVA: 0x7ADAD8C60
        public void RegisterChannelConfig(){} // RVA: 0x7ADAD9320
        public void CreateProvider(){} // RVA: 0x7ADADA4F0
        public void SyncDispatchMessage(){} // RVA: 0x7ADADA810
        public void CheckIncomingMessage(){} // RVA: 0x7ADADA8E0
        public void CheckReturnMessage(){} // RVA: 0x7ADADAB00
        public void IsLocalCall(){} // RVA: 0x7A81BD750
        public void GetCurrentChannelInfo(){} // RVA: 0x7ADADAD00
        public void .cctor(){} // RVA: 0x7ADADB130
    }

    public class CrossAppDomainChannel : Object
    {
        // ── Methods ──
        public void RegisterCrossAppDomainChannel(){} // RVA: 0x7ADADB640
        public void get_ChannelName(){} // RVA: 0x7ADADB800
        public void get_ChannelPriority(){} // RVA: 0x7A858A960
        public void get_ChannelData(){} // RVA: 0x7ADADB840
        public void StartListening(){} // RVA: 0x7A80D7310
        public void CreateMessageSink(){} // RVA: 0x7ADADB8A0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7ADADBA90
    }

    public class CrossAppDomainData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADADB480
        public void get_DomainID(){} // RVA: 0x7A83782A0
        public void get_ProcessID(){} // RVA: 0x7A81052C0
    }

    public class CrossAppDomainSink : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void GetSink(){} // RVA: 0x7ADADBB40
        public void get_TargetDomainId(){} // RVA: 0x7A8124910
        public void ProcessMessageInDomain(){} // RVA: 0x7ADADBEC0
        public void SyncProcessMessage(){} // RVA: 0x7ADADC2E0
        public void AsyncProcessMessage(){} // RVA: 0x7ADADC540
        public void SendAsyncMessage(){} // RVA: 0x7ADADC6B0
        public void .cctor(){} // RVA: 0x7ADADC770
        public void <AsyncProcessMessage>b__10_0(){} // RVA: 0x7ADADCA00
    }

    public class IChannel
    {
        // ── Methods ──
        public void get_ChannelName(){} // RVA: 0x7A7E00680
        public void get_ChannelPriority(){} // RVA: 0x7A7E00710
    }

    public class IChannelReceiver
    {
        // ── Methods ──
        public void get_ChannelData(){} // RVA: 0x7A7E00680
        public void StartListening(){} // RVA: 0x7A7E18800
    }

    public class IChannelSender
    {
        // ── Methods ──
        public void CreateMessageSink(){} // RVA: 0x7A7E06710
    }

    public class IClientChannelSinkProvider
    {
        // ── Methods ──
        public void set_Next(){} // RVA: 0x7A7E18800
    }

    public class ISecurableChannel
    {
        // ── Methods ──
        public void set_IsSecured(){} // RVA: 0x7A7E18C30
    }

    public class IServerChannelSinkProvider
    {
        // ── Methods ──
        public void set_Next(){} // RVA: 0x7A7E18800
    }

    public class SinkProviderData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADADCFF0
        public void get_Children(){} // RVA: 0x7A80DA7B0
        public void get_Properties(){} // RVA: 0x7A81052C0
    }

}