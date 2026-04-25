// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 4
// Methods: 11

namespace ThirdParty.Other.Steamworks.Data
{
    public class NetAddress : ValueType
    {
        public IPV4 Cleared; // 0x10
        public ushort port; // 0x20

        // ── Methods ──
        public void InternalClear(){} // RVA: 0x7FFAC4BF7060
        public void InternalSetIPv4(){} // RVA: 0x7FFAC4BF70E0
        public void InternalToString(){} // RVA: 0x7FFAC4BF7180
        public void From(){} // RVA: 0x7FFAC4BF7230
        public void get_Cleared(){} // RVA: 0x7FFAC4BF74A0
        public void ToString(){} // RVA: 0x7FFAC4BF7530
    }

    public class NetIdentity : ValueType
    {
        public 0x6B2938A8 type; // 0x10
        public int size; // 0x14
        public ulong steamid; // 0x18
        public Steamworks.Data.NetAddress netaddress; // 0x18

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC4BF6EF0
    }

    public class NewUrlLaunchParameters_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF0180
        public void .cctor(){} // RVA: 0x7FFAC4BF0190
    }

    public class NumberOfCurrentPlayers_t : ValueType
    {
        public byte CallbackType; // 0x10
        public int CPlayers; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEF7F0
        public void .cctor(){} // RVA: 0x7FFAC4BEF800
    }

}