// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Network
// Classes: 3
// Methods: 29

namespace VRC.SDK3.Network
{
    public class Stats : Object
    {
        public object _ThroughputPercentage;
        public object _RoundTripVariance;
        public object _RoundTripTime;
        public object _BytesInMax;
        public object _BytesInAverage;
        public object _BytesOutMax;
        public object _BytesOutAverage;
        public object _HitchesPerNetworkTick;
        public object _Suffering;
        public object _TimeInRoom;
        public object _Group;
        public object _ReceiveInterval;
        public object _GroupDelay;
        public object _FinalDelay;
        public object _Sleeping;
        public object _Size;
        public object _BytesPerSecondAverage;
        public object _TotalBytes;
        public object _UpdateInterval;
        public object _ReliableEventsInOutboundQueue;
        public object _LastSendTime;
        public object _LastReceiveTime;
        public object _PlayerGroup;
        public object _PlayerReceiveInterval;
        public object _PlayerGroupDelay;
        public object _PlayerFinalDelay;
        public object _PlayerSleeping;
        public object _PlayerSize;
        public object _PlayerBytesPerSecondAverage;
        public object _PlayerTotalBytes;
        public object _PlayerUpdateInterval;
        public object _PlayerReliableEventsInOutboundQueue;
        public object _PlayerLastSendTime;
        public object _PlayerLastReceiveTime;

        // ── Methods ──
        public void get_ThroughputPercentage(){} // RVA: 0xA6C3640
        public void get_RoundTripVariance(){} // RVA: 0xA6C36A0
        public void get_RoundTripTime(){} // RVA: 0xA6C3700
        public void get_BytesInMax(){} // RVA: 0xA6C3760
        public void get_BytesInAverage(){} // RVA: 0xA6C37C0
        public void get_BytesOutMax(){} // RVA: 0xA6C3820
        public void get_BytesOutAverage(){} // RVA: 0xA6C3880
        public void get_HitchesPerNetworkTick(){} // RVA: 0xA6C38E0
        public void get_Suffering(){} // RVA: 0xA6C3940
        public void get_TimeInRoom(){} // RVA: 0xA6C39A0
        public void Group(){} // RVA: 0xA6C3F50
        public void ReceiveInterval(){} // RVA: 0xA6C3FC0
        public void GroupDelay(){} // RVA: 0xA6C4030
        public void FinalDelay(){} // RVA: 0xA6C40A0
        public void Sleeping(){} // RVA: 0xA6C4110
        public void Size(){} // RVA: 0xA6C4180
        public void BytesPerSecondAverage(){} // RVA: 0xA6C41F0
        public void TotalBytes(){} // RVA: 0xA6C4260
        public void UpdateInterval(){} // RVA: 0xA6C42D0
        public void ReliableEventsInOutboundQueue(){} // RVA: 0xA6C4340
        public void LastSendTime(){} // RVA: 0xA6C43B0
        public void LastReceiveTime(){} // RVA: 0xA6C4420
    }

    public class VRCNetworkBehaviour : VRCNetworkBehaviour
    {
        public object OnNetworkBehaviourAwake;

        // ── Methods ──
        public void NetworkConfigure(){} // RVA: 0x894290
        public void add_OnNetworkBehaviourAwake(){} // RVA: 0xA6C3380
        public void remove_OnNetworkBehaviourAwake(){} // RVA: 0xA6C34B0
        public void Awake(){} // RVA: 0xA6C35E0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRCUdonSyncTypeConverter : Object
    {
        // ── Methods ──
        public void TypeToUdonType(){} // RVA: 0xA6C4490
        public void UdonTypeToType(){} // RVA: 0xA6C5180
    }

}