// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 4
// Methods: 11

namespace ThirdParty.Other.Steamworks.Data
{
    public class NetAddress : ValueType
    {
        public IPV4 ip; // 0x10

        // ── Methods ──
        public void InternalClear(){} // RVA: 0x7FFE82E63A60
        public void InternalSetIPv4(){} // RVA: 0x7FFE82E63AE0
        public void InternalToString(){} // RVA: 0x7FFE82E63B80
        public void From(){} // RVA: 0x7FFE82E63C30
        public void get_Cleared(){} // RVA: 0x7FFE82E63EA0
        public void ToString(){} // RVA: 0x7FFE82E63F30
    }

    public class NetIdentity : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE82E638F0
    }

    public class NewUrlLaunchParameters_t : ValueType
    {
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5CB80
        public void .cctor(){} // RVA: 0x7FFE82E5CB90
    }

    public class NumberOfCurrentPlayers_t : ValueType
    {
        public byte Success; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5C1F0
        public void .cctor(){} // RVA: 0x7FFE82E5C200
    }

}