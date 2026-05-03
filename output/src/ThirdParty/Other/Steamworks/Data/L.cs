// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 16
// Methods: 32

namespace ThirdParty.Other.Steamworks.Data
{
    public class LeaderboardFindResult_t : ValueType
    {
        public ulong SteamLeaderboard; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5BEC0
        public void .cctor(){} // RVA: 0x7FFE82E5BED0
    }

    public class LeaderboardScoreUploaded_t : ValueType
    {
        public byte Success; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5C0E0
        public void .cctor(){} // RVA: 0x7FFE82E5C0F0
    }

    public class LeaderboardScoresDownloaded_t : ValueType
    {
        public ulong SteamLeaderboard; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5BFD0
        public void .cctor(){} // RVA: 0x7FFE82E5BFE0
    }

    public class LeaderboardUGCSet_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5C740
        public void .cctor(){} // RVA: 0x7FFE82E5C750
    }

    public class LicensesUpdated_t : ValueType
    {
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E558D0
        public void .cctor(){} // RVA: 0x7FFE82E558E0
    }

    public class Lobby : ValueType
    {
        public Steamworks.SteamId _id; // 0x10

        // ── Methods ──
        public void set_Id(){} // RVA: 0x7FFE82889220
        public void .ctor(){} // RVA: 0x7FFE82889220
    }

    public class LobbyChatMsg_t : ValueType
    {
        public ulong SteamIDLobby; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E58AC0
        public void .cctor(){} // RVA: 0x7FFE82E58AD0
    }

    public class LobbyChatUpdate_t : ValueType
    {
        public ulong SteamIDLobby; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E589B0
        public void .cctor(){} // RVA: 0x7FFE82E589C0
    }

    public class LobbyCreated_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E58EF0
        public void .cctor(){} // RVA: 0x7FFE82E58F00
    }

    public class LobbyDataUpdate_t : ValueType
    {
        public ulong SteamIDLobby; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E588A0
        public void .cctor(){} // RVA: 0x7FFE82E588B0
    }

    public class LobbyEnter_t : ValueType
    {
        public ulong SteamIDLobby; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E58790
        public void .cctor(){} // RVA: 0x7FFE82E587A0
    }

    public class LobbyGameCreated_t : ValueType
    {
        public ulong SteamIDLobby; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E58BD0
        public void .cctor(){} // RVA: 0x7FFE82E58BE0
    }

    public class LobbyInvite_t : ValueType
    {
        public ulong SteamIDUser; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E58680
        public void .cctor(){} // RVA: 0x7FFE82E58690
    }

    public class LobbyKicked_t : ValueType
    {
        public ulong SteamIDLobby; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE81C16D60
        public void .cctor(){} // RVA: 0x7FFE82E58DF0
    }

    public class LobbyMatchList_t : ValueType
    {
        public uint LobbiesMatching; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E58CE0
        public void .cctor(){} // RVA: 0x7FFE82E58CF0
    }

    public class LowBatteryPower_t : ValueType
    {
        public byte MinutesBatteryLeft; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E57E00
        public void .cctor(){} // RVA: 0x7FFE82E57E10
    }

}