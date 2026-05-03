// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Network
// Classes: 3
// Methods: 41

namespace VRC.SDK3.Network
{
    public class Stats : Object
    {
        public System.Func`1<float> _ThroughputPercentage;
        public System.Func`1<float> _RoundTripVariance; // 0x8
        public System.Func`1<int> _RoundTripTime; // 0x10
        public System.Func`1<int> _BytesInMax; // 0x18
        public System.Func`1<float> _BytesInAverage; // 0x20
        public System.Func`1<int> _BytesOutMax; // 0x28
        public System.Func`1<float> _BytesOutAverage; // 0x30
        public System.Func`1<float> _HitchesPerNetworkTick; // 0x38
        public System.Func`1<float> _Suffering; // 0x40
        public System.Func`1<float> _TimeInRoom; // 0x48

        // ── Methods ──
        public void get_ThroughputPercentage(){} // RVA: 0x7FFE8A473560
        public void get_RoundTripVariance(){} // RVA: 0x7FFE8A4735C0
        public void get_RoundTripTime(){} // RVA: 0x7FFE8A473620
        public void get_BytesInMax(){} // RVA: 0x7FFE8A473680
        public void get_BytesInAverage(){} // RVA: 0x7FFE8A4736E0
        public void get_BytesOutMax(){} // RVA: 0x7FFE8A473740
        public void get_BytesOutAverage(){} // RVA: 0x7FFE8A4737A0
        public void get_HitchesPerNetworkTick(){} // RVA: 0x7FFE8A473800
        public void get_Suffering(){} // RVA: 0x7FFE8A473860
        public void get_TimeInRoom(){} // RVA: 0x7FFE8A4738C0
        public void Group(){} // RVA: 0x7FFE8A473E70 | overloaded x2
        public void ReceiveInterval(){} // RVA: 0x7FFE8A473EE0 | overloaded x2
        public void GroupDelay(){} // RVA: 0x7FFE8A473F50 | overloaded x2
        public void FinalDelay(){} // RVA: 0x7FFE8A473FC0 | overloaded x2
        public void Sleeping(){} // RVA: 0x7FFE8A474030 | overloaded x2
        public void Size(){} // RVA: 0x7FFE8A4740A0 | overloaded x2
        public void BytesPerSecondAverage(){} // RVA: 0x7FFE8A474110 | overloaded x2
        public void TotalBytes(){} // RVA: 0x7FFE8A474180 | overloaded x2
        public void UpdateInterval(){} // RVA: 0x7FFE8A4741F0 | overloaded x2
        public void ReliableEventsInOutboundQueue(){} // RVA: 0x7FFE8A474260 | overloaded x2
        public void LastSendTime(){} // RVA: 0x7FFE8A4742D0 | overloaded x2
        public void LastReceiveTime(){} // RVA: 0x7FFE8A474340 | overloaded x2
    }

    public class VRCNetworkBehaviour : VRCNetworkBehaviour
    {
        // ── Methods ──
        public void NetworkConfigure(){} // RVA: 0x7FFE80E45FE0
        public void add_OnNetworkBehaviourAwake(){} // RVA: 0x7FFE8A4732A0
        public void remove_OnNetworkBehaviourAwake(){} // RVA: 0x7FFE8A4733D0
        public void Awake(){} // RVA: 0x7FFE8A473500
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRCUdonSyncTypeConverter : Object
    {
        // ── Methods ──
        public void TypeToUdonType(){} // RVA: 0x7FFE8A4743B0
        public void UdonTypeToType(){} // RVA: 0x7FFE8A475150
    }

}