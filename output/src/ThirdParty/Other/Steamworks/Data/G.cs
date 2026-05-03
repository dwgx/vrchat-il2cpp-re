// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 28
// Methods: 58

namespace ThirdParty.Other.Steamworks.Data
{
    public class GSClientAchievementStatus_t : ValueType
    {
        public ulong SteamID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E62E50
        public void .cctor(){} // RVA: 0x7FFE82E62E60
    }

    public class GSClientApprove_t : ValueType
    {
        public ulong SteamID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E62B20
        public void .cctor(){} // RVA: 0x7FFE82E62B30
    }

    public class GSClientDeny_t : ValueType
    {
        public ulong SteamID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E62C30
        public void .cctor(){} // RVA: 0x7FFE82E62C40
    }

    public class GSClientGroupStatus_t : ValueType
    {
        public ulong SteamIDUser; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E63180
        public void .cctor(){} // RVA: 0x7FFE82E63190
    }

    public class GSClientKick_t : ValueType
    {
        public ulong SteamID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E62D40
        public void .cctor(){} // RVA: 0x7FFE82E62D50
    }

    public class GSGameplayStats_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E63070
        public void .cctor(){} // RVA: 0x7FFE82E63080
    }

    public class GSPolicyResponse_t : ValueType
    {
        public byte Secure; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E62F60
        public void .cctor(){} // RVA: 0x7FFE82E62F70
    }

    public class GSReputation_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E63290
        public void .cctor(){} // RVA: 0x7FFE82E632A0
    }

    public class GSStatsReceived_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E635C0
        public void .cctor(){} // RVA: 0x7FFE82E635D0
    }

    public class GSStatsStored_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E636D0
        public void .cctor(){} // RVA: 0x7FFE82E636E0
    }

    public class GameConnectedChatJoin_t : ValueType
    {
        public ulong SteamIDClanChat; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E57030
        public void .cctor(){} // RVA: 0x7FFE82E57040
    }

    public class GameConnectedChatLeave_t : ValueType
    {
        public ulong SteamIDClanChat; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E57140
        public void .cctor(){} // RVA: 0x7FFE82E57150
    }

    public class GameConnectedClanChatMsg_t : ValueType
    {
        public ulong SteamIDClanChat; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E56F20
        public void .cctor(){} // RVA: 0x7FFE82E56F30
    }

    public class GameConnectedFriendChatMsg_t : ValueType
    {
        public ulong SteamIDUser; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E57470
        public void .cctor(){} // RVA: 0x7FFE82E57480
    }

    public class GameId : ValueType
    {
    }

    public class GameLobbyJoinRequested_t : ValueType
    {
        public ulong SteamIDLobby; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E568C0
        public void .cctor(){} // RVA: 0x7FFE82E568D0
    }

    public class GameOverlayActivated_t : ValueType
    {
        public byte Active; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E56480
        public void .cctor(){} // RVA: 0x7FFE82E56490
    }

    public class GameRichPresenceJoinRequested_t : ValueType
    {
        public ulong SteamIDFriend; // 0x10

        // ── Methods ──
        public void ConnectUTF8(){} // RVA: 0x7FFE82E56D00
        public void get_CallbackType(){} // RVA: 0x7FFE82E56E10
        public void .cctor(){} // RVA: 0x7FFE82E56E20
    }

    public class GameServerChangeRequested_t : ValueType
    {
        public byte[] Server; // 0x10

        // ── Methods ──
        public void ServerUTF8(){} // RVA: 0x7FFE82E56590
        public void PasswordUTF8(){} // RVA: 0x7FFE82E566A0
        public void get_CallbackType(){} // RVA: 0x7FFE82E567B0
        public void .cctor(){} // RVA: 0x7FFE82E567C0
    }

    public class GameWebCallback_t : ValueType
    {
        public byte[] URL; // 0x10

        // ── Methods ──
        public void URLUTF8(){} // RVA: 0x7FFE82E55E20
        public void get_CallbackType(){} // RVA: 0x7FFE82E55F30
        public void .cctor(){} // RVA: 0x7FFE82E55F40
    }

    public class GamepadTextInputDismissed_t : ValueType
    {
        public bool Submitted; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E58240
        public void .cctor(){} // RVA: 0x7FFE82E58250
    }

    public class GetAppDependenciesResult_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5FB50
        public void .cctor(){} // RVA: 0x7FFE82E5FB60
    }

    public class GetAuthSessionTicketResponse_t : ValueType
    {
        public uint AuthTicket; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E55D10
        public void .cctor(){} // RVA: 0x7FFE82E55D20
    }

    public class GetOPFSettingsResult_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E62190
        public void .cctor(){} // RVA: 0x7FFE82E621A0
    }

    public class GetUserItemVoteResult_t : ValueType
    {
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5F3E0
        public void .cctor(){} // RVA: 0x7FFE82E5F3F0
    }

    public class GetVideoURLResult_t : ValueType
    {
        public 0x666873EC Result; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E62080
        public void .cctor(){} // RVA: 0x7FFE82E62090
    }

    public class GlobalAchievementPercentagesReady_t : ValueType
    {
        public ulong GameID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5C630
        public void .cctor(){} // RVA: 0x7FFE82E5C640
    }

    public class GlobalStatsReceived_t : ValueType
    {
        public ulong GameID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5C850
        public void .cctor(){} // RVA: 0x7FFE82E5C860
    }

}