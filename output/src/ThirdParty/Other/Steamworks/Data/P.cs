// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 6
// Methods: 14

namespace ThirdParty.Other.Steamworks.Data
{
    public class P2PSessionConnectFail_t : ValueType
    {
        public object SteamIDRemote;
        public object P2PSessionError;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C380
        public void .cctor(){} // RVA: 0x2956C40
    }

    public class P2PSessionRequest_t : ValueType
    {
        public object SteamIDRemote;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C370
        public void .cctor(){} // RVA: 0x2956B60
    }

    public class PSNGameBootInviteResult_t : ValueType
    {
        public object GameBootInviteExists;
        public object SteamIDLobby;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x1470F0
        public void .cctor(){} // RVA: 0x2953680
    }

    public class PersonaStateChange_t : ValueType
    {
        public object SteamID;
        public object ChangeFlags;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x145780
        public void .cctor(){} // RVA: 0x2951110
    }

    public class PlaybackStatusHasChanged_t : ValueType
    {
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C3B0
        public void .cctor(){} // RVA: 0x2956EE0
    }

    public class PublishedFileId : ValueType
    {
        public object Value;

        // ── Methods ──
        public void ToString(){} // RVA: 0x145350
        public void GetHashCode(){} // RVA: 0x145250
        public void Equals(){} // RVA: 0x14F7F0
        public void CompareTo(){} // RVA: 0x14F800
    }

}