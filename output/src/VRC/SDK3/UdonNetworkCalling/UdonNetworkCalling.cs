// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.UdonNetworkCalling
// Classes: 4
// Methods: 38

namespace VRC.SDK3.UdonNetworkCalling
{
    public class NetworkCallableAttribute
    {
        // ── Methods ──
        public void get_MaxEventsPerSecond(){} // RVA: 0x7FFAF2DDA5C0
        public void set_MaxEventsPerSecond(){} // RVA: 0x7FFAF2D900C0
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
    }

    public class NetworkCalling
    {
        // ── Methods ──
        public void get_InNetworkCall(){} // RVA: 0x7FFAFC4ABD90
        public void set_InNetworkCall(){} // RVA: 0x7FFAFC4ABDF0
        public void get_CallingPlayer(){} // RVA: 0x7FFAFC4ABE50
        public void set_CallingPlayer(){} // RVA: 0x7FFAFC4ABEB0
        public void get_SendCustomNetworkEventProxy(){} // RVA: 0x7FFAFC4ABF70
        public void set_SendCustomNetworkEventProxy(){} // RVA: 0x7FFAFC4ABFD0
        public void get_GetQueuedEventsProxy(){} // RVA: 0x7FFAFC4AC090
        public void set_GetQueuedEventsProxy(){} // RVA: 0x7FFAFC4AC0F0
        public void get_GetAllQueuedEventsProxy(){} // RVA: 0x7FFAFC4AC1B0
        public void set_GetAllQueuedEventsProxy(){} // RVA: 0x7FFAFC4AC210
        public void CheckMainThread(){} // RVA: 0x7FFAFC4AC2D0
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFAFC4AD9F0 | overloaded x9
        public void SendCustomNetworkEventInternal(){} // RVA: 0x7FFAFC4ADE90
        public void WithNetworkCallingContext(){} // RVA: 0x7FFAFC4ADFF0
        public void GetQueuedEvents(){} // RVA: 0x7FFAFC4AE150
        public void GetAllQueuedEvents(){} // RVA: 0x7FFAFC4AE270
        public void .cctor(){} // RVA: 0x7FFAFC4AE380
    }

    public class NetworkCallingEntrypointMetadata
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2D907C0
        public void get_MaxEventsPerSecond(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Parameters(){} // RVA: 0x7FFAF2DBB0C0
        public void .ctor(){} // RVA: 0x7FFAFC4AE680
        public void Validate(){} // RVA: 0x7FFAFC4AE7C0
        public void ValidateOnce(){} // RVA: 0x7FFAFC4AEDA0
    }

    public class NetworkCallingParameterMetadata
    {
        public object startTimeSec;
        public object endTimeSec;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void get_Type(){} // RVA: 0x7FFAF2DA84E0
        public void .ctor(){} // RVA: 0x7FFAFC4AEDC0 | overloaded x2
    }

}