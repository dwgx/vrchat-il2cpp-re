// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.UdonNetworkCalling
// Classes: 4
// Methods: 38

namespace VRC.SDK3.UdonNetworkCalling
{
    public class NetworkCallableAttribute : Attribute
    {
        public int _maxEventsPerSecond; // 0x10

        // ── Methods ──
        public void get_MaxEventsPerSecond(){} // RVA: 0x7FFE811485C0
        public void set_MaxEventsPerSecond(){} // RVA: 0x7FFE810FE0C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    public class NetworkCalling : Object
    {
        public bool _inNetworkCall;
        public VRC.SDKBase.VRCPlayerApi _callingPlayer; // 0x8
        public SendNetworkEventDelegate _sendCustomNetworkEventProxy; // 0x10
        public GetQueuedEventsDelegate _getQueuedEventsProxy; // 0x18
        public GetAllQueuedEventsDelegate _getAllQueuedEventsProxy; // 0x20

        // ── Methods ──
        public void get_InNetworkCall(){} // RVA: 0x7FFE8A4577C0
        public void set_InNetworkCall(){} // RVA: 0x7FFE8A457820
        public void get_CallingPlayer(){} // RVA: 0x7FFE8A457880
        public void set_CallingPlayer(){} // RVA: 0x7FFE8A4578E0
        public void get_SendCustomNetworkEventProxy(){} // RVA: 0x7FFE8A4579A0
        public void set_SendCustomNetworkEventProxy(){} // RVA: 0x7FFE8A457A00
        public void get_GetQueuedEventsProxy(){} // RVA: 0x7FFE8A457AC0
        public void set_GetQueuedEventsProxy(){} // RVA: 0x7FFE8A457B20
        public void get_GetAllQueuedEventsProxy(){} // RVA: 0x7FFE8A457BE0
        public void set_GetAllQueuedEventsProxy(){} // RVA: 0x7FFE8A457C40
        public void CheckMainThread(){} // RVA: 0x7FFE8A457D00
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFE8A459420 | overloaded x9
        public void SendCustomNetworkEventInternal(){} // RVA: 0x7FFE8A4598C0
        public void WithNetworkCallingContext(){} // RVA: 0x7FFE8A459A20
        public void GetQueuedEvents(){} // RVA: 0x7FFE8A459B80
        public void GetAllQueuedEvents(){} // RVA: 0x7FFE8A459CA0
        public void .cctor(){} // RVA: 0x7FFE8A459DB0
    }

    public class NetworkCallingEntrypointMetadata : Object
    {
        public int RATE_LIMIT_MAX;
        public int _maxEventsPerSecond; // 0x10
        public string _name; // 0x18

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void get_MaxEventsPerSecond(){} // RVA: 0x7FFE811485C0
        public void get_Parameters(){} // RVA: 0x7FFE811290C0
        public void .ctor(){} // RVA: 0x7FFE8A45A0B0
        public void Validate(){} // RVA: 0x7FFE8A45A1F0
        public void ValidateOnce(){} // RVA: 0x7FFE8A45A7D0
    }

    public class NetworkCallingParameterMetadata : Object
    {
        public string _name; // 0x10
        public 0x6665C88C _type; // 0x18

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void get_Type(){} // RVA: 0x7FFE811164E0
        public void .ctor(){} // RVA: 0x7FFE8A45A7F0 | overloaded x2
    }

}