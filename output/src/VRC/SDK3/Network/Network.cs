// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Network
// Classes: 3
// Methods: 29

namespace VRC.SDK3.Network
{
    public class Stats : Object
    {
        // ── Methods ──
        public void get_ThroughputPercentage(){} // RVA: 0x7B1856E80
        public void get_RoundTripVariance(){} // RVA: 0x7B1856EE0
        public void get_RoundTripTime(){} // RVA: 0x7B1856F40
        public void get_BytesInMax(){} // RVA: 0x7B1856FA0
        public void get_BytesInAverage(){} // RVA: 0x7B1857000
        public void get_BytesOutMax(){} // RVA: 0x7B1857060
        public void get_BytesOutAverage(){} // RVA: 0x7B18570C0
        public void get_HitchesPerNetworkTick(){} // RVA: 0x7B1857120
        public void get_Suffering(){} // RVA: 0x7B1857180
        public void get_TimeInRoom(){} // RVA: 0x7B18571E0
        public void Group(){} // RVA: 0x7B1857790
        public void ReceiveInterval(){} // RVA: 0x7B1857800
        public void GroupDelay(){} // RVA: 0x7B1857870
        public void FinalDelay(){} // RVA: 0x7B18578E0
        public void Sleeping(){} // RVA: 0x7B1857950
        public void Size(){} // RVA: 0x7B18579C0
        public void BytesPerSecondAverage(){} // RVA: 0x7B1857A30
        public void TotalBytes(){} // RVA: 0x7B1857AA0
        public void UpdateInterval(){} // RVA: 0x7B1857B10
        public void ReliableEventsInOutboundQueue(){} // RVA: 0x7B1857B80
        public void LastSendTime(){} // RVA: 0x7B1857BF0
        public void LastReceiveTime(){} // RVA: 0x7B1857C60
    }

    public class VRCNetworkBehaviour : VRCNetworkBehaviour
    {
        // ── Methods ──
        public void NetworkConfigure(){} // RVA: 0x7A7E18770
        public void add_OnNetworkBehaviourAwake(){} // RVA: 0x7B1856BC0
        public void remove_OnNetworkBehaviourAwake(){} // RVA: 0x7B1856CF0
        public void Awake(){} // RVA: 0x7B1856E20
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VRCUdonSyncTypeConverter : Object
    {
        // ── Methods ──
        public void TypeToUdonType(){} // RVA: 0x7B1857CD0
        public void UdonTypeToType(){} // RVA: 0x7B1858A70
    }

}