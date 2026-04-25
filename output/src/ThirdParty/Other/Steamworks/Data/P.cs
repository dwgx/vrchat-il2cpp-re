// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 6
// Methods: 15

namespace ThirdParty.Other.Steamworks.Data
{
    public class P2PSessionConnectFail_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public byte P2PSessionError; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF06D0
        public void .cctor(){} // RVA: 0x7FFAC4BF06E0
    }

    public class P2PSessionRequest_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF05C0
        public void .cctor(){} // RVA: 0x7FFAC4BF05D0
    }

    public class PSNGameBootInviteResult_t : ValueType
    {
        public bool CallbackType; // 0x10
        public ulong SteamIDLobby; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEC600
        public void .cctor(){} // RVA: 0x7FFAC4BEC610
    }

    public class PersonaStateChange_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public int ChangeFlags; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BE9970
        public void .cctor(){} // RVA: 0x7FFAC4BE9980
    }

    public class PlaybackStatusHasChanged_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF0A00
        public void .cctor(){} // RVA: 0x7FFAC4BF0A10
    }

    public class PublishedFileId : ValueType
    {
        public ulong Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC4BE7610
        public void GetHashCode(){} // RVA: 0x7FFAC4BE71C0
        public void Equals(){} // RVA: 0x7FFAC4BF79F0 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFAC4BF7A00
    }

}