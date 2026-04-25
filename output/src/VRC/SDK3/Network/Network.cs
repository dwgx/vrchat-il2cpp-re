// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Network
// Classes: 3
// Methods: 41

namespace VRC.SDK3.Network
{
    public class Stats : Object
    {
        public System.Func`1<float> ThroughputPercentage;
        public System.Func`1<float> RoundTripVariance; // 0x8
        public System.Func`1<int> RoundTripTime; // 0x10
        public System.Func`1<int> BytesInMax; // 0x18
        public System.Func`1<float> BytesInAverage; // 0x20
        public System.Func`1<int> BytesOutMax; // 0x28
        public System.Func`1<float> BytesOutAverage; // 0x30
        public System.Func`1<float> HitchesPerNetworkTick; // 0x38
        public System.Func`1<float> Suffering; // 0x40
        public System.Func`1<float> TimeInRoom; // 0x48
        public System.Func`2<UnityEngine.GameObject,int> _Group; // 0x50
        public System.Func`2<UnityEngine.GameObject,float> _ReceiveInterval; // 0x58
        public System.Func`2<UnityEngine.GameObject,float> _GroupDelay; // 0x60
        public System.Func`2<UnityEngine.GameObject,float> _FinalDelay; // 0x68
        public System.Func`2<UnityEngine.GameObject,bool> _Sleeping; // 0x70
        public System.Func`2<UnityEngine.GameObject,int> _Size; // 0x78
        public System.Func`2<UnityEngine.GameObject,float> _BytesPerSecondAverage; // 0x80
        public System.Func`2<UnityEngine.GameObject,int> _TotalBytes; // 0x88
        public System.Func`2<UnityEngine.GameObject,float> _UpdateInterval; // 0x90
        public System.Func`2<UnityEngine.GameObject,int> _ReliableEventsInOutboundQueue; // 0x98
        public System.Func`2<UnityEngine.GameObject,float> _LastSendTime; // 0xA0
        public System.Func`2<UnityEngine.GameObject,float> _LastReceiveTime; // 0xA8
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,int> _PlayerGroup; // 0xB0
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _PlayerReceiveInterval; // 0xB8
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _PlayerGroupDelay; // 0xC0
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _PlayerFinalDelay; // 0xC8
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,bool> _PlayerSleeping; // 0xD0
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,int> _PlayerSize; // 0xD8
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _PlayerBytesPerSecondAverage; // 0xE0
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,int> _PlayerTotalBytes; // 0xE8
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _PlayerUpdateInterval; // 0xF0
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,int> _PlayerReliableEventsInOutboundQueue; // 0xF8
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _PlayerLastSendTime; // 0x100
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,float> _PlayerLastReceiveTime; // 0x108

        // ── Methods ──
        public void get_ThroughputPercentage(){} // RVA: 0x7FFACC00DCB0
        public void get_RoundTripVariance(){} // RVA: 0x7FFACC00DD10
        public void get_RoundTripTime(){} // RVA: 0x7FFACC00DD70
        public void get_BytesInMax(){} // RVA: 0x7FFACC00DDD0
        public void get_BytesInAverage(){} // RVA: 0x7FFACC00DE30
        public void get_BytesOutMax(){} // RVA: 0x7FFACC00DE90
        public void get_BytesOutAverage(){} // RVA: 0x7FFACC00DEF0
        public void get_HitchesPerNetworkTick(){} // RVA: 0x7FFACC00DF50
        public void get_Suffering(){} // RVA: 0x7FFACC00DFB0
        public void get_TimeInRoom(){} // RVA: 0x7FFACC00E010
        public void Group(){} // RVA: 0x7FFACC00E5C0 | overloaded x2
        public void ReceiveInterval(){} // RVA: 0x7FFACC00E630 | overloaded x2
        public void GroupDelay(){} // RVA: 0x7FFACC00E6A0 | overloaded x2
        public void FinalDelay(){} // RVA: 0x7FFACC00E710 | overloaded x2
        public void Sleeping(){} // RVA: 0x7FFACC00E780 | overloaded x2
        public void Size(){} // RVA: 0x7FFACC00E7F0 | overloaded x2
        public void BytesPerSecondAverage(){} // RVA: 0x7FFACC00E860 | overloaded x2
        public void TotalBytes(){} // RVA: 0x7FFACC00E8D0 | overloaded x2
        public void UpdateInterval(){} // RVA: 0x7FFACC00E940 | overloaded x2
        public void ReliableEventsInOutboundQueue(){} // RVA: 0x7FFACC00E9B0 | overloaded x2
        public void LastSendTime(){} // RVA: 0x7FFACC00EA20 | overloaded x2
        public void LastReceiveTime(){} // RVA: 0x7FFACC00EA90 | overloaded x2
    }

    public class VRCNetworkBehaviour : VRCNetworkBehaviour
    {
        public System.Action`1<VRC.SDK3.Network.VRCNetworkBehaviour> OnNetworkBehaviourAwake;

        // ── Methods ──
        public void NetworkConfigure(){} // RVA: 0x7FFAC2C70980
        public void add_OnNetworkBehaviourAwake(){} // RVA: 0x7FFACC00D9F0
        public void remove_OnNetworkBehaviourAwake(){} // RVA: 0x7FFACC00DB20
        public void Awake(){} // RVA: 0x7FFACC00DC50
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRCUdonSyncTypeConverter : Object
    {
        // ── Methods ──
        public void TypeToUdonType(){} // RVA: 0x7FFACC00EB00
        public void UdonTypeToType(){} // RVA: 0x7FFACC00F8A0
    }

}