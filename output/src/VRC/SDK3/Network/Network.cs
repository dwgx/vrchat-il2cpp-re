// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Network
// Classes: 2
// Methods: 39

namespace VRC.SDK3.Network
{
    public class Stats : Object
    {
        public object ThroughputPercentage;
        public object RoundTripVariance;
        public object RoundTripTime;
        public object BytesInMax;
        public object BytesInAverage;
        public object BytesOutMax;
        public object BytesOutAverage;
        public object HitchesPerNetworkTick;
        public object Suffering;
        public object TimeInRoom;

        // ── Methods ──
        public void get_ThroughputPercentage(){} // RVA: 0x7FFD5742DCB0
        public void get_RoundTripVariance(){} // RVA: 0x7FFD5742DD10
        public void get_RoundTripTime(){} // RVA: 0x7FFD5742DD70
        public void get_BytesInMax(){} // RVA: 0x7FFD5742DDD0
        public void get_BytesInAverage(){} // RVA: 0x7FFD5742DE30
        public void get_BytesOutMax(){} // RVA: 0x7FFD5742DE90
        public void get_BytesOutAverage(){} // RVA: 0x7FFD5742DEF0
        public void get_HitchesPerNetworkTick(){} // RVA: 0x7FFD5742DF50
        public void get_Suffering(){} // RVA: 0x7FFD5742DFB0
        public void get_TimeInRoom(){} // RVA: 0x7FFD5742E010
        public void Group(){} // RVA: 0x7FFD5742E5C0 | overloaded x2
        public void ReceiveInterval(){} // RVA: 0x7FFD5742E630 | overloaded x2
        public void GroupDelay(){} // RVA: 0x7FFD5742E6A0 | overloaded x2
        public void FinalDelay(){} // RVA: 0x7FFD5742E710 | overloaded x2
        public void Sleeping(){} // RVA: 0x7FFD5742E780 | overloaded x2
        public void Size(){} // RVA: 0x7FFD5742E7F0 | overloaded x2
        public void BytesPerSecondAverage(){} // RVA: 0x7FFD5742E860 | overloaded x2
        public void TotalBytes(){} // RVA: 0x7FFD5742E8D0 | overloaded x2
        public void UpdateInterval(){} // RVA: 0x7FFD5742E940 | overloaded x2
        public void ReliableEventsInOutboundQueue(){} // RVA: 0x7FFD5742E9B0 | overloaded x2
        public void LastSendTime(){} // RVA: 0x7FFD5742EA20 | overloaded x2
        public void LastReceiveTime(){} // RVA: 0x7FFD5742EA90 | overloaded x2
    }

    public class VRCNetworkBehaviour : VRCNetworkBehaviour
    {
        public ileFullDirectoryInformation<ene.ext> OnNetworkBehaviourAwake;

        // ── Methods ──
        public void NetworkConfigure(){} // RVA: 0x7FFD4E090980
        public void add_OnNetworkBehaviourAwake(){} // RVA: 0x7FFD5742D9F0
        public void remove_OnNetworkBehaviourAwake(){} // RVA: 0x7FFD5742DB20
        public void Awake(){} // RVA: 0x7FFD5742DC50
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

}