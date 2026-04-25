// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 16
// Methods: 32

namespace ThirdParty.Other.Steamworks.Data
{
    public class LeaderboardFindResult_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public byte LeaderboardFound; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEF4C0
        public void .cctor(){} // RVA: 0x7FFAC4BEF4D0
    }

    public class LeaderboardScoreUploaded_t : ValueType
    {
        public byte CallbackType; // 0x10
        public ulong SteamLeaderboard; // 0x18
        public int Score; // 0x20
        public byte ScoreChanged; // 0x24
        public int GlobalRankNew; // 0x28
        public int GlobalRankPrevious; // 0x2C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEF6E0
        public void .cctor(){} // RVA: 0x7FFAC4BEF6F0
    }

    public class LeaderboardScoresDownloaded_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamLeaderboardEntries; // 0x18
        public int CEntryCount; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEF5D0
        public void .cctor(){} // RVA: 0x7FFAC4BEF5E0
    }

    public class LeaderboardUGCSet_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public ulong SteamLeaderboard; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEFD40
        public void .cctor(){} // RVA: 0x7FFAC4BEFD50
    }

    public class LicensesUpdated_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BE8ED0
        public void .cctor(){} // RVA: 0x7FFAC4BE8EE0
    }

    public class Lobby : ValueType
    {
        public Steamworks.SteamId Id; // 0x10

        // ── Methods ──
        public void set_Id(){} // RVA: 0x7FFAC45BB120
        public void .ctor(){} // RVA: 0x7FFAC45BB120
    }

    public class LobbyChatMsg_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDUser; // 0x18
        public byte ChatEntryType; // 0x20
        public uint ChatID; // 0x24
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEC0C0
        public void .cctor(){} // RVA: 0x7FFAC4BEC0D0
    }

    public class LobbyChatUpdate_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDUserChanged; // 0x18
        public ulong SteamIDMakingChange; // 0x20
        public uint GfChatMemberStateChange; // 0x28
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEBFB0
        public void .cctor(){} // RVA: 0x7FFAC4BEBFC0
    }

    public class LobbyCreated_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public ulong SteamIDLobby; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEC4F0
        public void .cctor(){} // RVA: 0x7FFAC4BEC500
    }

    public class LobbyDataUpdate_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDMember; // 0x18
        public byte Success; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEBEA0
        public void .cctor(){} // RVA: 0x7FFAC4BEBEB0
    }

    public class LobbyEnter_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public uint GfChatPermissions; // 0x18
        public bool Locked; // 0x1C
        public uint EChatRoomEnterResponse; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEBD90
        public void .cctor(){} // RVA: 0x7FFAC4BEBDA0
    }

    public class LobbyGameCreated_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDGameServer; // 0x18
        public uint IP; // 0x20
        public ushort Port; // 0x24
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEC1D0
        public void .cctor(){} // RVA: 0x7FFAC4BEC1E0
    }

    public class LobbyInvite_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDLobby; // 0x18
        public ulong GameID; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEBC80
        public void .cctor(){} // RVA: 0x7FFAC4BEBC90
    }

    public class LobbyKicked_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDAdmin; // 0x18
        public byte KickedDueToDisconnect; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC3BB6A40
        public void .cctor(){} // RVA: 0x7FFAC4BEC3F0
    }

    public class LobbyMatchList_t : ValueType
    {
        public uint CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEC2E0
        public void .cctor(){} // RVA: 0x7FFAC4BEC2F0
    }

    public class LowBatteryPower_t : ValueType
    {
        public byte CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEB400
        public void .cctor(){} // RVA: 0x7FFAC4BEB410
    }

}