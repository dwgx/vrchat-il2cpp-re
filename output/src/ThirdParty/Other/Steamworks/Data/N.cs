// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 4
// Methods: 11

namespace ThirdParty.Other.Steamworks.Data
{
    public class NetAddress : ValueType
    {
        public object ip;
        public object port;

        // ── Methods ──
        public void InternalClear(){} // RVA: 0x295C340
        public void InternalSetIPv4(){} // RVA: 0x295C3C0
        public void InternalToString(){} // RVA: 0x295C460
        public void From(){} // RVA: 0x295C510
        public void get_Cleared(){} // RVA: 0x295C780
        public void ToString(){} // RVA: 0x14ECD0
    }

    public class NetIdentity : ValueType
    {
        public object type;
        public object size;
        public object steamid;
        public object netaddress;

        // ── Methods ──
        public void ToString(){} // RVA: 0x14EB80
    }

    public class NewUrlLaunchParameters_t : ValueType
    {
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14BE80
        public void .cctor(){} // RVA: 0x29567E0
    }

    public class NumberOfCurrentPlayers_t : ValueType
    {
        public object Success;
        public object CPlayers;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14BAE0
        public void .cctor(){} // RVA: 0x2955FD0
    }

}