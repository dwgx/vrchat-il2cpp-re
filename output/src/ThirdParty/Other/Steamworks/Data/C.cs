// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 9
// Methods: 22

namespace ThirdParty.Other.Steamworks.Data
{
    public class ChangeNumOpenSlotsCallback_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BED2C0
        public void .cctor(){} // RVA: 0x7FFAC4BED2D0
    }

    public class CheckFileSignature_t : ValueType
    {
        public 0x6B28D918 CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEB730
        public void .cctor(){} // RVA: 0x7FFAC4BEB740
    }

    public class ClanOfficerListResponse_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public int COfficers; // 0x18
        public byte Success; // 0x1C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEA0E0
        public void .cctor(){} // RVA: 0x7FFAC4BEA0F0
    }

    public class ClientGameServerDeny_t : ValueType
    {
        public uint CallbackType; // 0x10
        public uint GameServerIP; // 0x14
        public ushort GameServerPort; // 0x18
        public ushort Secure; // 0x1A
        public uint Reason; // 0x1C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BE8CB0
        public void .cctor(){} // RVA: 0x7FFAC4BE8CC0
    }

    public class ComputeNewPlayerCompatibilityResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public int CPlayersThatDontLikeCandidate; // 0x14
        public int CPlayersThatCandidateDoesntLike; // 0x18
        public int CClanPlayersThatDontLikeCandidate; // 0x1C
        public ulong SteamIDCandidate; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF6AB0
        public void .cctor(){} // RVA: 0x7FFAC4BF6AC0
    }

    public class Connection : ValueType
    {
        public uint Id; // 0x10

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAC4420210
        public void Equals(){} // RVA: 0x7FFAC4BF7EA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void ToString(){} // RVA: 0x7FFAC4BF7F30
        public void Accept(){} // RVA: 0x7FFAC4BF7FD0
        public void Close(){} // RVA: 0x7FFAC4BF80B0
    }

    public class ConnectionInfo : ValueType
    {
        public Steamworks.Data.NetIdentity State; // 0x10
        public long userData; // 0x98
        public Steamworks.Data.Socket listenSocket; // 0xA0
        public Steamworks.Data.NetAddress address; // 0xA4
        public ushort pad; // 0xB6
        public Steamworks.Data.SteamNetworkingPOPID popRemote; // 0xB8
        public Steamworks.Data.SteamNetworkingPOPID popRelay; // 0xBC
        public 0x6B28DC88 state; // 0xC0
        public int endReason; // 0xC4
        public string endDebug; // 0xC8
        public string connectionDescription; // 0xD0

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFAC4BF81F0
    }

    public class CreateBeaconCallback_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public ulong BeaconID; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BED0A0
        public void .cctor(){} // RVA: 0x7FFAC4BED0B0
    }

    public class CreateItemResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public bool UserNeedsToAcceptWorkshopLegalAgreement; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF2380
        public void .cctor(){} // RVA: 0x7FFAC4BF2390
    }

}