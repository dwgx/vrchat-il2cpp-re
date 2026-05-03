// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Channels
// Classes: 14
// Methods: 50

namespace ThirdParty.DotNet.System.Runtime.Remoting.Channels
{
    public class AsyncRequest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A057B0
    }

    public class CADSerializer : Object
    {
        // ── Methods ──
        public void DeserializeMessage(){} // RVA: 0x7FFE8682FFD0
        public void SerializeMessage(){} // RVA: 0x7FFE86830010
        public void DeserializeObjectSafe(){} // RVA: 0x7FFE86830150
        public void SerializeObject(){} // RVA: 0x7FFE868302C0
        public void DeserializeObject(){} // RVA: 0x7FFE86830400
    }

    public class ChannelServices : Object
    {
        public System.Collections.ArrayList registeredChannels;

        // ── Methods ──
        public void get_CrossContextChannel(){} // RVA: 0x7FFE8682B730
        public void CreateClientChannelSinkChain(){} // RVA: 0x7FFE8682BE80 | overloaded x2
        public void RegisterChannel(){} // RVA: 0x7FFE8682C030 | overloaded x2
        public void RegisterChannelConfig(){} // RVA: 0x7FFE8682C720
        public void CreateProvider(){} // RVA: 0x7FFE8682D930
        public void SyncDispatchMessage(){} // RVA: 0x7FFE8682DC50
        public void CheckIncomingMessage(){} // RVA: 0x7FFE8682DD20
        public void CheckReturnMessage(){} // RVA: 0x7FFE8682DF50
        public void IsLocalCall(){} // RVA: 0x7FFE811E0850
        public void GetCurrentChannelInfo(){} // RVA: 0x7FFE8682E150
        public void .cctor(){} // RVA: 0x7FFE8682E5C0
    }

    public class CrossAppDomainChannel : Object
    {
        public object s_lock;
        public object field_1; // 0x424
        public object field_2; // 0x425

        // ── Methods ──
        public void RegisterCrossAppDomainChannel(){} // RVA: 0x7FFE8682EAD0
        public void get_ChannelName(){} // RVA: 0x7FFE8682ECC0
        public void get_ChannelPriority(){} // RVA: 0x7FFE815881D0
        public void get_ChannelData(){} // RVA: 0x7FFE8682ED00
        public void StartListening(){} // RVA: 0x7FFE810FB310
        public void CreateMessageSink(){} // RVA: 0x7FFE8682ED60
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8682EF50
    }

    public class CrossAppDomainData : Object
    {
        public object _ContextID; // 0x10
        public int _DomainID; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8682E910
        public void get_DomainID(){} // RVA: 0x7FFE813DB630
        public void get_ProcessID(){} // RVA: 0x7FFE811290C0
    }

    public class CrossAppDomainSink : Object
    {
        public System.Collections.Hashtable s_sinks;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void GetSink(){} // RVA: 0x7FFE8682F000
        public void get_TargetDomainId(){} // RVA: 0x7FFE811485C0
        public void ProcessMessageInDomain(){} // RVA: 0x7FFE8682F3C0
        public void SyncProcessMessage(){} // RVA: 0x7FFE8682F7E0
        public void AsyncProcessMessage(){} // RVA: 0x7FFE8682FA40
        public void SendAsyncMessage(){} // RVA: 0x7FFE8682FBB0
        public void .cctor(){} // RVA: 0x7FFE8682FC70
        public void <AsyncProcessMessage>b__10_0(){} // RVA: 0x7FFE8682FF00
    }

    public class IChannel
    {
        // ── Methods ──
        public void get_ChannelName(){} // RVA: 0x7FFE80E2E2E0
        public void get_ChannelPriority(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IChannelDataStore
    {
    }

    public class IChannelReceiver
    {
        // ── Methods ──
        public void get_ChannelData(){} // RVA: 0x7FFE80E2E2E0
        public void StartListening(){} // RVA: 0x7FFE80E460A0
    }

    public class IChannelSender
    {
        // ── Methods ──
        public void CreateMessageSink(){} // RVA: 0x7FFE80E403A0
    }

    public class IClientChannelSinkProvider
    {
        // ── Methods ──
        public void set_Next(){} // RVA: 0x7FFE80E460A0
    }

    public class ISecurableChannel
    {
        // ── Methods ──
        public void set_IsSecured(){} // RVA: 0x7FFE80E466C0
    }

    public class IServerChannelSinkProvider
    {
        // ── Methods ──
        public void set_Next(){} // RVA: 0x7FFE80E460A0
    }

    public class SinkProviderData : Object
    {
        public string sinkName; // 0x10
        public System.Collections.ArrayList children; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868304F0
        public void get_Children(){} // RVA: 0x7FFE810FE7C0
        public void get_Properties(){} // RVA: 0x7FFE811290C0
    }

}