// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Channels
// Classes: 14
// Methods: 50

namespace ThirdParty.DotNet.System.Runtime.Remoting.Channels
{
    public class AsyncRequest : Object
    {
        public System.Runtime.Remoting.Messaging.IMessageSink ReplySink; // 0x10
        public System.Runtime.Remoting.Messaging.IMessage MsgRequest; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC46FBCC0
    }

    public class CADSerializer : Object
    {
        // ── Methods ──
        public void DeserializeMessage(){} // RVA: 0x7FFAC84866C0
        public void SerializeMessage(){} // RVA: 0x7FFAC8486700
        public void DeserializeObjectSafe(){} // RVA: 0x7FFAC8486840
        public void SerializeObject(){} // RVA: 0x7FFAC84869B0
        public void DeserializeObject(){} // RVA: 0x7FFAC8486AF0
    }

    public class ChannelServices : Object
    {
        public System.Collections.ArrayList CrossContextChannel;
        public System.Collections.ArrayList delayedClientChannels; // 0x8
        public System.Runtime.Remoting.Contexts.CrossContextChannel _crossContextSink; // 0x10
        public string CrossContextUrl; // 0x18
        public System.Collections.IList oldStartModeTypes; // 0x20

        // ── Methods ──
        public void get_CrossContextChannel(){} // RVA: 0x7FFAC8481E20
        public void CreateClientChannelSinkChain(){} // RVA: 0x7FFAC8482570 | overloaded x2
        public void RegisterChannel(){} // RVA: 0x7FFAC8482720 | overloaded x2
        public void RegisterChannelConfig(){} // RVA: 0x7FFAC8482E10
        public void CreateProvider(){} // RVA: 0x7FFAC8484020
        public void SyncDispatchMessage(){} // RVA: 0x7FFAC8484340
        public void CheckIncomingMessage(){} // RVA: 0x7FFAC8484410
        public void CheckReturnMessage(){} // RVA: 0x7FFAC8484640
        public void IsLocalCall(){} // RVA: 0x7FFAC3006850
        public void GetCurrentChannelInfo(){} // RVA: 0x7FFAC8484840
        public void .cctor(){} // RVA: 0x7FFAC8484CB0
    }

    public class CrossAppDomainChannel : Object
    {
        public object ChannelName;

        // ── Methods ──
        public void RegisterCrossAppDomainChannel(){} // RVA: 0x7FFAC84851C0
        public void get_ChannelName(){} // RVA: 0x7FFAC84853B0
        public void get_ChannelPriority(){} // RVA: 0x7FFAC332C610
        public void get_ChannelData(){} // RVA: 0x7FFAC84853F0
        public void StartListening(){} // RVA: 0x7FFAC2F21310
        public void CreateMessageSink(){} // RVA: 0x7FFAC8485450
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8485640
    }

    public class CrossAppDomainData : Object
    {
        public object DomainID; // 0x10
        public int ProcessID; // 0x18
        public string _processGuid; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8485000
        public void get_DomainID(){} // RVA: 0x7FFAC3157800
        public void get_ProcessID(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class CrossAppDomainSink : Object
    {
        public System.Collections.Hashtable TargetDomainId;
        public System.Reflection.MethodInfo processMessageMethod; // 0x8
        public int _domainID; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void GetSink(){} // RVA: 0x7FFAC84856F0
        public void get_TargetDomainId(){} // RVA: 0x7FFAC2F6E5C0
        public void ProcessMessageInDomain(){} // RVA: 0x7FFAC8485AB0
        public void SyncProcessMessage(){} // RVA: 0x7FFAC8485ED0
        public void AsyncProcessMessage(){} // RVA: 0x7FFAC8486130
        public void SendAsyncMessage(){} // RVA: 0x7FFAC84862A0
        public void .cctor(){} // RVA: 0x7FFAC8486360
        public void <AsyncProcessMessage>b__10_0(){} // RVA: 0x7FFAC84865F0
    }

    public class IChannel
    {
        public object ChannelName;
        public object ChannelPriority;

        // ── Methods ──
        public void get_ChannelName(){} // RVA: 0x7FFAC2C58E90
        public void get_ChannelPriority(){} // RVA: 0x7FFAC2C59960
    }

    public class IChannelDataStore
    {
    }

    public class IChannelReceiver
    {
        public object ChannelData;

        // ── Methods ──
        public void get_ChannelData(){} // RVA: 0x7FFAC2C58E90
        public void StartListening(){} // RVA: 0x7FFAC2C70A40
    }

    public class IChannelSender
    {
        // ── Methods ──
        public void CreateMessageSink(){} // RVA: 0x7FFAC2C6AE80
    }

    public class IClientChannelSinkProvider
    {
        public object Next;

        // ── Methods ──
        public void set_Next(){} // RVA: 0x7FFAC2C70A40
    }

    public class ISecurableChannel
    {
        public object IsSecured;

        // ── Methods ──
        public void set_IsSecured(){} // RVA: 0x7FFAC2C71060
    }

    public class IServerChannelSinkProvider
    {
        public object Next;

        // ── Methods ──
        public void set_Next(){} // RVA: 0x7FFAC2C70A40
    }

    public class SinkProviderData : Object
    {
        public string Children; // 0x10
        public System.Collections.ArrayList Properties; // 0x18
        public System.Collections.Hashtable properties; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8486BE0
        public void get_Children(){} // RVA: 0x7FFAC2F247C0
        public void get_Properties(){} // RVA: 0x7FFAC2F4F0C0
    }

}