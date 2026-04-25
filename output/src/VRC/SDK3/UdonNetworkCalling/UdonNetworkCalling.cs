// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.UdonNetworkCalling
// Classes: 4
// Methods: 38

namespace VRC.SDK3.UdonNetworkCalling
{
    public class NetworkCallableAttribute : Attribute
    {
        public int MaxEventsPerSecond; // 0x10

        // ── Methods ──
        public void get_MaxEventsPerSecond(){} // RVA: 0x7FFAC2F6E5C0
        public void set_MaxEventsPerSecond(){} // RVA: 0x7FFAC2F240C0
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class NetworkCalling : Object
    {
        public bool InNetworkCall;
        public VRC.SDKBase.VRCPlayerApi CallingPlayer; // 0x8
        public SendNetworkEventDelegate SendCustomNetworkEventProxy; // 0x10
        public GetQueuedEventsDelegate GetQueuedEventsProxy; // 0x18
        public GetAllQueuedEventsDelegate GetAllQueuedEventsProxy; // 0x20
        public object[] _parameters; // 0x28

        // ── Methods ──
        public void get_InNetworkCall(){} // RVA: 0x7FFACBFF1FC0
        public void set_InNetworkCall(){} // RVA: 0x7FFACBFF2020
        public void get_CallingPlayer(){} // RVA: 0x7FFACBFF2080
        public void set_CallingPlayer(){} // RVA: 0x7FFACBFF20E0
        public void get_SendCustomNetworkEventProxy(){} // RVA: 0x7FFACBFF21A0
        public void set_SendCustomNetworkEventProxy(){} // RVA: 0x7FFACBFF2200
        public void get_GetQueuedEventsProxy(){} // RVA: 0x7FFACBFF22C0
        public void set_GetQueuedEventsProxy(){} // RVA: 0x7FFACBFF2320
        public void get_GetAllQueuedEventsProxy(){} // RVA: 0x7FFACBFF23E0
        public void set_GetAllQueuedEventsProxy(){} // RVA: 0x7FFACBFF2440
        public void CheckMainThread(){} // RVA: 0x7FFACBFF2500
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFACBFF3C20 | overloaded x9
        public void SendCustomNetworkEventInternal(){} // RVA: 0x7FFACBFF40C0
        public void WithNetworkCallingContext(){} // RVA: 0x7FFACBFF4220
        public void GetQueuedEvents(){} // RVA: 0x7FFACBFF4380
        public void GetAllQueuedEvents(){} // RVA: 0x7FFACBFF44A0
        public void .cctor(){} // RVA: 0x7FFACBFF45B0
    }

    public class NetworkCallingEntrypointMetadata : Object
    {
        public int Name;
        public int MaxEventsPerSecond; // 0x10
        public string Parameters; // 0x18
        public VRC.SDK3.UdonNetworkCalling.NetworkCallingParameterMetadata[] _parameters; // 0x20
        public bool _validated; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void get_MaxEventsPerSecond(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Parameters(){} // RVA: 0x7FFAC2F4F0C0
        public void .ctor(){} // RVA: 0x7FFACBFF48B0
        public void Validate(){} // RVA: 0x7FFACBFF49F0
        public void ValidateOnce(){} // RVA: 0x7FFACBFF4FD0
    }

    public class NetworkCallingParameterMetadata : Object
    {
        public string Name; // 0x10
        public 0x6B262CB0 Type; // 0x18

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void get_Type(){} // RVA: 0x7FFAC2F3C4E0
        public void .ctor(){} // RVA: 0x7FFACBFF4FF0 | overloaded x2
    }

}