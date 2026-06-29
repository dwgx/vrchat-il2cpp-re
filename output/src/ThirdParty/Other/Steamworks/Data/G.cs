// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 27
// Methods: 58

namespace ThirdParty.Other.Steamworks.Data
{
    public class GSClientAchievementStatus_t : ValueType
    {
        public object SteamID;
        public object PchAchievement;
        public object Unlocked;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14E7E0
        public void .cctor(){} // RVA: 0x295B940
    }

    public class GSClientApprove_t : ValueType
    {
        public object SteamID;
        public object OwnerSteamID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14E1C0
        public void .cctor(){} // RVA: 0x295B6A0
    }

    public class GSClientDeny_t : ValueType
    {
        public object SteamID;
        public object DenyReason;
        public object OptionalText;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14E4D0
        public void .cctor(){} // RVA: 0x295B780
    }

    public class GSClientGroupStatus_t : ValueType
    {
        public object SteamIDUser;
        public object SteamIDGroup;
        public object Member;
        public object Officer;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14E810
        public void .cctor(){} // RVA: 0x295BBE0
    }

    public class GSClientKick_t : ValueType
    {
        public object SteamID;
        public object DenyReason;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14E4E0
        public void .cctor(){} // RVA: 0x295B860
    }

    public class GSGameplayStats_t : ValueType
    {
        public object Result;
        public object Rank;
        public object TotalConnects;
        public object TotalMinutesPlayed;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14E800
        public void .cctor(){} // RVA: 0x295BB00
    }

    public class GSPolicyResponse_t : ValueType
    {
        public object Secure;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14E7F0
        public void .cctor(){} // RVA: 0x295BA20
    }

    public class GSReputation_t : ValueType
    {
        public object Result;
        public object ReputationScore;
        public object Banned;
        public object BannedIP;
        public object BannedPort;
        public object BannedGameID;
        public object BanExpires;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14E820
        public void .cctor(){} // RVA: 0x295BCC0
    }

    public class GSStatsReceived_t : ValueType
    {
        public object Result;
        public object SteamIDUser;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14E850
        public void .cctor(){} // RVA: 0x295BF60
    }

    public class GSStatsStored_t : ValueType
    {
        public object Result;
        public object SteamIDUser;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14E860
        public void .cctor(){} // RVA: 0x295C040
    }

    public class GameConnectedChatJoin_t : ValueType
    {
        public object SteamIDClanChat;
        public object SteamIDUser;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x146600
        public void .cctor(){} // RVA: 0x2951C20
    }

    public class GameConnectedChatLeave_t : ValueType
    {
        public object SteamIDClanChat;
        public object SteamIDUser;
        public object Kicked;
        public object Dropped;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x146610
        public void .cctor(){} // RVA: 0x2951D00
    }

    public class GameConnectedClanChatMsg_t : ValueType
    {
        public object SteamIDClanChat;
        public object SteamIDUser;
        public object MessageID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x1465F0
        public void .cctor(){} // RVA: 0x2951B40
    }

    public class GameConnectedFriendChatMsg_t : ValueType
    {
        public object SteamIDUser;
        public object MessageID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x146640
        public void .cctor(){} // RVA: 0x2951FA0
    }

    public class GameLobbyJoinRequested_t : ValueType
    {
        public object SteamIDLobby;
        public object SteamIDFriend;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x146400
        public void .cctor(){} // RVA: 0x29515D0
    }

    public class GameOverlayActivated_t : ValueType
    {
        public object Active;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x145790
        public void .cctor(){} // RVA: 0x29511F0
    }

    public class GameRichPresenceJoinRequested_t : ValueType
    {
        public object SteamIDFriend;
        public object Connect;
        public object _datasize;

        // ── Methods ──
        public void ConnectUTF8(){} // RVA: 0x1465D0
        public void get_CallbackType(){} // RVA: 0x1465E0
        public void .cctor(){} // RVA: 0x2951A60
    }

    public class GameServerChangeRequested_t : ValueType
    {
        public object Server;
        public object Password;
        public object _datasize;

        // ── Methods ──
        public void ServerUTF8(){} // RVA: 0x1463D0
        public void PasswordUTF8(){} // RVA: 0x1463E0
        public void get_CallbackType(){} // RVA: 0x1463F0
        public void .cctor(){} // RVA: 0x29514F0
    }

    public class GameWebCallback_t : ValueType
    {
        public object URL;
        public object _datasize;

        // ── Methods ──
        public void URLUTF8(){} // RVA: 0x1455A0
        public void get_CallbackType(){} // RVA: 0x1455B0
        public void .cctor(){} // RVA: 0x2950D90
    }

    public class GamepadTextInputDismissed_t : ValueType
    {
        public object Submitted;
        public object SubmittedText;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147020
        public void .cctor(){} // RVA: 0x2952B30
    }

    public class GetAppDependenciesResult_t : ValueType
    {
        public object Result;
        public object PublishedFileId;
        public object GAppIDs;
        public object NumAppDependencies;
        public object TotalNumAppDependencies;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14CD10
        public void .cctor(){} // RVA: 0x2958F40
    }

    public class GetAuthSessionTicketResponse_t : ValueType
    {
        public object AuthTicket;
        public object Result;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x145400
        public void .cctor(){} // RVA: 0x2950BA0
    }

    public class GetOPFSettingsResult_t : ValueType
    {
        public object Result;
        public object VideoAppID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14DB50
        public void .cctor(){} // RVA: 0x295AEC0
    }

    public class GetUserItemVoteResult_t : ValueType
    {
        public object PublishedFileId;
        public object Result;
        public object VotedUp;
        public object VotedDown;
        public object VoteSkipped;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C8A0
        public void .cctor(){} // RVA: 0x2958920
    }

    public class GetVideoURLResult_t : ValueType
    {
        public object Result;
        public object VideoAppID;
        public object URL;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14DB40
        public void .cctor(){} // RVA: 0x295ADE0
    }

    public class GlobalAchievementPercentagesReady_t : ValueType
    {
        public object GameID;
        public object Result;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14BE30
        public void .cctor(){} // RVA: 0x2956380
    }

    public class GlobalStatsReceived_t : ValueType
    {
        public object GameID;
        public object Result;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14BE50
        public void .cctor(){} // RVA: 0x2956540
    }

}