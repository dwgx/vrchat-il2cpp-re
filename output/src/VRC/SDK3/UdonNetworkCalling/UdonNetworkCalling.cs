// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.UdonNetworkCalling
// Classes: 4
// Methods: 38

namespace VRC.SDK3.UdonNetworkCalling
{
    public class NetworkCallableAttribute
    {
        // ── Methods ──
        public void get_MaxEventsPerSecond(){} // RVA: 0x32A5C0
        public void set_MaxEventsPerSecond(){} // RVA: 0x2E00C0
        public void .ctor(){} // RVA: 0x2E00C0
    }

    public class NetworkCalling
    {
        // ── Methods ──
        public void get_InNetworkCall(){} // RVA: 0x99FBD90
        public void set_InNetworkCall(){} // RVA: 0x99FBDF0
        public void get_CallingPlayer(){} // RVA: 0x99FBE50
        public void set_CallingPlayer(){} // RVA: 0x99FBEB0
        public void get_SendCustomNetworkEventProxy(){} // RVA: 0x99FBF70
        public void set_SendCustomNetworkEventProxy(){} // RVA: 0x99FBFD0
        public void get_GetQueuedEventsProxy(){} // RVA: 0x99FC090
        public void set_GetQueuedEventsProxy(){} // RVA: 0x99FC0F0
        public void get_GetAllQueuedEventsProxy(){} // RVA: 0x99FC1B0
        public void set_GetAllQueuedEventsProxy(){} // RVA: 0x99FC210
        public void CheckMainThread(){} // RVA: 0x99FC2D0
        public void SendCustomNetworkEvent(){} // RVA: 0x99FD9F0 | overloaded x9
        public void SendCustomNetworkEventInternal(){} // RVA: 0x99FDE90
        public void WithNetworkCallingContext(){} // RVA: 0x99FDFF0
        public void GetQueuedEvents(){} // RVA: 0x99FE150
        public void GetAllQueuedEvents(){} // RVA: 0x99FE270
        public void .cctor(){} // RVA: 0x99FE380
    }

    public class NetworkCallingEntrypointMetadata
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x2E07C0
        public void get_MaxEventsPerSecond(){} // RVA: 0x32A5C0
        public void get_Parameters(){} // RVA: 0x30B0C0
        public void .ctor(){} // RVA: 0x99FE680
        public void Validate(){} // RVA: 0x99FE7C0
        public void ValidateOnce(){} // RVA: 0x99FEDA0
    }

    public class NetworkCallingParameterMetadata
    {
        public object startTimeSec;
        public object endTimeSec;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
        public void get_Type(){} // RVA: 0x2F84E0
        public void .ctor(){} // RVA: 0x99FEDC0 | overloaded x2
    }

}