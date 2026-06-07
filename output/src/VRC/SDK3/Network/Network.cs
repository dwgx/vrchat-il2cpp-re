// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Network
// Classes: 3
// Methods: 41

namespace VRC.SDK3.Network
{
    public class Stats
    {
        // ── Methods ──
        public void get_ThroughputPercentage(){} // RVA: 0x9A17AF0
        public void get_RoundTripVariance(){} // RVA: 0x9A17B50
        public void get_RoundTripTime(){} // RVA: 0x9A17BB0
        public void get_BytesInMax(){} // RVA: 0x9A17C10
        public void get_BytesInAverage(){} // RVA: 0x9A17C70
        public void get_BytesOutMax(){} // RVA: 0x9A17CD0
        public void get_BytesOutAverage(){} // RVA: 0x9A17D30
        public void get_HitchesPerNetworkTick(){} // RVA: 0x9A17D90
        public void get_Suffering(){} // RVA: 0x9A17DF0
        public void get_TimeInRoom(){} // RVA: 0x9A17E50
        public void Group(){} // RVA: 0x9A18400 | overloaded x2
        public void ReceiveInterval(){} // RVA: 0x9A18470 | overloaded x2
        public void GroupDelay(){} // RVA: 0x9A184E0 | overloaded x2
        public void FinalDelay(){} // RVA: 0x9A18550 | overloaded x2
        public void Sleeping(){} // RVA: 0x9A185C0 | overloaded x2
        public void Size(){} // RVA: 0x9A18630 | overloaded x2
        public void BytesPerSecondAverage(){} // RVA: 0x9A186A0 | overloaded x2
        public void TotalBytes(){} // RVA: 0x9A18710 | overloaded x2
        public void UpdateInterval(){} // RVA: 0x9A18780 | overloaded x2
        public void ReliableEventsInOutboundQueue(){} // RVA: 0x9A187F0 | overloaded x2
        public void LastSendTime(){} // RVA: 0x9A18860 | overloaded x2
        public void LastReceiveTime(){} // RVA: 0x9A188D0 | overloaded x2
    }

    public class VRCNetworkBehaviour
    {
        // ── Methods ──
        public void NetworkConfigure(){} // RVA: 0x24A50
        public void add_OnNetworkBehaviourAwake(){} // RVA: 0x9A17830
        public void remove_OnNetworkBehaviourAwake(){} // RVA: 0x9A17960
        public void Awake(){} // RVA: 0x9A17A90
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRCUdonSyncTypeConverter
    {
        // ── Methods ──
        public void TypeToUdonType(){} // RVA: 0x9A18940
        public void UdonTypeToType(){} // RVA: 0x9A196E0
    }

}