// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 6
// Methods: 15

namespace ThirdParty.Other.Steamworks.Data
{
    public class P2PSessionConnectFail_t : ValueType
    {
        public ulong SteamIDRemote; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5D0D0
        public void .cctor(){} // RVA: 0x7FFE82E5D0E0
    }

    public class P2PSessionRequest_t : ValueType
    {
        public ulong SteamIDRemote; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5CFC0
        public void .cctor(){} // RVA: 0x7FFE82E5CFD0
    }

    public class PSNGameBootInviteResult_t : ValueType
    {
        public bool GameBootInviteExists; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E59000
        public void .cctor(){} // RVA: 0x7FFE82E59010
    }

    public class PersonaStateChange_t : ValueType
    {
        public ulong SteamID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E56370
        public void .cctor(){} // RVA: 0x7FFE82E56380
    }

    public class PlaybackStatusHasChanged_t : ValueType
    {
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5D400
        public void .cctor(){} // RVA: 0x7FFE82E5D410
    }

    public class PublishedFileId : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE82E54010
        public void GetHashCode(){} // RVA: 0x7FFE82E53BC0
        public void Equals(){} // RVA: 0x7FFE82E643F0 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFE82E64400
    }

}