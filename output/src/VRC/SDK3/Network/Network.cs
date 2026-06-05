// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Network
// Classes: 3
// Methods: 41

namespace VRC.SDK3.Network
{
    public class Stats
    {
        // ── Methods ──
        public void get_ThroughputPercentage(){} // RVA: 0x7FFAFC4C7AF0
        public void get_RoundTripVariance(){} // RVA: 0x7FFAFC4C7B50
        public void get_RoundTripTime(){} // RVA: 0x7FFAFC4C7BB0
        public void get_BytesInMax(){} // RVA: 0x7FFAFC4C7C10
        public void get_BytesInAverage(){} // RVA: 0x7FFAFC4C7C70
        public void get_BytesOutMax(){} // RVA: 0x7FFAFC4C7CD0
        public void get_BytesOutAverage(){} // RVA: 0x7FFAFC4C7D30
        public void get_HitchesPerNetworkTick(){} // RVA: 0x7FFAFC4C7D90
        public void get_Suffering(){} // RVA: 0x7FFAFC4C7DF0
        public void get_TimeInRoom(){} // RVA: 0x7FFAFC4C7E50
        public void Group(){} // RVA: 0x7FFAFC4C8400 | overloaded x2
        public void ReceiveInterval(){} // RVA: 0x7FFAFC4C8470 | overloaded x2
        public void GroupDelay(){} // RVA: 0x7FFAFC4C84E0 | overloaded x2
        public void FinalDelay(){} // RVA: 0x7FFAFC4C8550 | overloaded x2
        public void Sleeping(){} // RVA: 0x7FFAFC4C85C0 | overloaded x2
        public void Size(){} // RVA: 0x7FFAFC4C8630 | overloaded x2
        public void BytesPerSecondAverage(){} // RVA: 0x7FFAFC4C86A0 | overloaded x2
        public void TotalBytes(){} // RVA: 0x7FFAFC4C8710 | overloaded x2
        public void UpdateInterval(){} // RVA: 0x7FFAFC4C8780 | overloaded x2
        public void ReliableEventsInOutboundQueue(){} // RVA: 0x7FFAFC4C87F0 | overloaded x2
        public void LastSendTime(){} // RVA: 0x7FFAFC4C8860 | overloaded x2
        public void LastReceiveTime(){} // RVA: 0x7FFAFC4C88D0 | overloaded x2
    }

    public class VRCNetworkBehaviour
    {
        // ── Methods ──
        public void NetworkConfigure(){} // RVA: 0x7FFAF2AD4A50
        public void add_OnNetworkBehaviourAwake(){} // RVA: 0x7FFAFC4C7830
        public void remove_OnNetworkBehaviourAwake(){} // RVA: 0x7FFAFC4C7960
        public void Awake(){} // RVA: 0x7FFAFC4C7A90
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRCUdonSyncTypeConverter
    {
        // ── Methods ──
        public void TypeToUdonType(){} // RVA: 0x7FFAFC4C8940
        public void UdonTypeToType(){} // RVA: 0x7FFAFC4C96E0
    }

}