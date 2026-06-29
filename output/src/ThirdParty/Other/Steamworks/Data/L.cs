// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 16
// Methods: 32

namespace ThirdParty.Other.Steamworks.Data
{
    public class LeaderboardFindResult_t : ValueType
    {
        public object SteamLeaderboard;
        public object LeaderboardFound;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14BAB0
        public void .cctor(){} // RVA: 0x2955D30
    }

    public class LeaderboardScoreUploaded_t : ValueType
    {
        public object Success;
        public object SteamLeaderboard;
        public object Score;
        public object ScoreChanged;
        public object GlobalRankNew;
        public object GlobalRankPrevious;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14BAD0
        public void .cctor(){} // RVA: 0x2955EF0
    }

    public class LeaderboardScoresDownloaded_t : ValueType
    {
        public object SteamLeaderboard;
        public object SteamLeaderboardEntries;
        public object CEntryCount;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14BAC0
        public void .cctor(){} // RVA: 0x2955E10
    }

    public class LeaderboardUGCSet_t : ValueType
    {
        public object Result;
        public object SteamLeaderboard;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14BE40
        public void .cctor(){} // RVA: 0x2956460
    }

    public class LicensesUpdated_t : ValueType
    {
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x1453C0
        public void .cctor(){} // RVA: 0x2950820
    }

    public class Lobby : ValueType
    {
        public object _id;

        // ── Methods ──
        public void set_Id(){} // RVA: 0x93050
        public void .ctor(){} // RVA: 0x93050
    }

    public class LobbyChatMsg_t : ValueType
    {
        public object SteamIDLobby;
        public object SteamIDUser;
        public object ChatEntryType;
        public object ChatID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x1470A0
        public void .cctor(){} // RVA: 0x2953230
    }

    public class LobbyChatUpdate_t : ValueType
    {
        public object SteamIDLobby;
        public object SteamIDUserChanged;
        public object SteamIDMakingChange;
        public object GfChatMemberStateChange;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147090
        public void .cctor(){} // RVA: 0x2953150
    }

    public class LobbyCreated_t : ValueType
    {
        public object Result;
        public object SteamIDLobby;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x1470E0
        public void .cctor(){} // RVA: 0x29535A0
    }

    public class LobbyDataUpdate_t : ValueType
    {
        public object SteamIDLobby;
        public object SteamIDMember;
        public object Success;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147080
        public void .cctor(){} // RVA: 0x2953070
    }

    public class LobbyEnter_t : ValueType
    {
        public object SteamIDLobby;
        public object GfChatPermissions;
        public object Locked;
        public object EChatRoomEnterResponse;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147070
        public void .cctor(){} // RVA: 0x2952F90
    }

    public class LobbyGameCreated_t : ValueType
    {
        public object SteamIDLobby;
        public object SteamIDGameServer;
        public object IP;
        public object Port;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x1470B0
        public void .cctor(){} // RVA: 0x2953310
    }

    public class LobbyInvite_t : ValueType
    {
        public object SteamIDUser;
        public object SteamIDLobby;
        public object GameID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147060
        public void .cctor(){} // RVA: 0x2952EB0
    }

    public class LobbyKicked_t : ValueType
    {
        public object SteamIDLobby;
        public object SteamIDAdmin;
        public object KickedDueToDisconnect;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x1470D0
        public void .cctor(){} // RVA: 0x29534C0
    }

    public class LobbyMatchList_t : ValueType
    {
        public object LobbiesMatching;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x1470C0
        public void .cctor(){} // RVA: 0x29533F0
    }

    public class LowBatteryPower_t : ValueType
    {
        public object MinutesBatteryLeft;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x146FE0
        public void .cctor(){} // RVA: 0x29527B0
    }

}