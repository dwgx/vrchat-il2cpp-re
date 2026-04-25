// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 28
// Methods: 58

namespace ThirdParty.Other.Steamworks.Data
{
    public class GSClientAchievementStatus_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public byte[] PchAchievement; // 0x18
        public bool Unlocked; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF6450
        public void .cctor(){} // RVA: 0x7FFAC4BF6460
    }

    public class GSClientApprove_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong OwnerSteamID; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF6120
        public void .cctor(){} // RVA: 0x7FFAC4BF6130
    }

    public class GSClientDeny_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public 0x6B28D658 DenyReason; // 0x18
        public byte[] OptionalText; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF6230
        public void .cctor(){} // RVA: 0x7FFAC4BF6240
    }

    public class GSClientGroupStatus_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDGroup; // 0x18
        public bool Member; // 0x20
        public bool Officer; // 0x21
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF6780
        public void .cctor(){} // RVA: 0x7FFAC4BF6790
    }

    public class GSClientKick_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public 0x6B28D658 DenyReason; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF6340
        public void .cctor(){} // RVA: 0x7FFAC4BF6350
    }

    public class GSGameplayStats_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public int Rank; // 0x14
        public uint TotalConnects; // 0x18
        public uint TotalMinutesPlayed; // 0x1C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF6670
        public void .cctor(){} // RVA: 0x7FFAC4BF6680
    }

    public class GSPolicyResponse_t : ValueType
    {
        public byte CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF6560
        public void .cctor(){} // RVA: 0x7FFAC4BF6570
    }

    public class GSReputation_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public uint ReputationScore; // 0x14
        public bool Banned; // 0x18
        public uint BannedIP; // 0x1C
        public ushort BannedPort; // 0x20
        public ulong BannedGameID; // 0x28
        public uint BanExpires; // 0x30
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF6890
        public void .cctor(){} // RVA: 0x7FFAC4BF68A0
    }

    public class GSStatsReceived_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public ulong SteamIDUser; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF6BC0
        public void .cctor(){} // RVA: 0x7FFAC4BF6BD0
    }

    public class GSStatsStored_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public ulong SteamIDUser; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF6CD0
        public void .cctor(){} // RVA: 0x7FFAC4BF6CE0
    }

    public class GameConnectedChatJoin_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDUser; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEA630
        public void .cctor(){} // RVA: 0x7FFAC4BEA640
    }

    public class GameConnectedChatLeave_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDUser; // 0x18
        public bool Kicked; // 0x20
        public bool Dropped; // 0x21
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEA740
        public void .cctor(){} // RVA: 0x7FFAC4BEA750
    }

    public class GameConnectedClanChatMsg_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDUser; // 0x18
        public int MessageID; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEA520
        public void .cctor(){} // RVA: 0x7FFAC4BEA530
    }

    public class GameConnectedFriendChatMsg_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public int MessageID; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEAA70
        public void .cctor(){} // RVA: 0x7FFAC4BEAA80
    }

    public class GameId : ValueType
    {
        public ulong Value; // 0x10
    }

    public class GameLobbyJoinRequested_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDFriend; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BE9EC0
        public void .cctor(){} // RVA: 0x7FFAC4BE9ED0
    }

    public class GameOverlayActivated_t : ValueType
    {
        public byte CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BE9A80
        public void .cctor(){} // RVA: 0x7FFAC4BE9A90
    }

    public class GameRichPresenceJoinRequested_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public byte[] Connect; // 0x18
        public int _datasize;

        // ── Methods ──
        public void ConnectUTF8(){} // RVA: 0x7FFAC4BEA300
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEA410
        public void .cctor(){} // RVA: 0x7FFAC4BEA420
    }

    public class GameServerChangeRequested_t : ValueType
    {
        public byte[] CallbackType; // 0x10
        public byte[] Password; // 0x18
        public int _datasize;

        // ── Methods ──
        public void ServerUTF8(){} // RVA: 0x7FFAC4BE9B90
        public void PasswordUTF8(){} // RVA: 0x7FFAC4BE9CA0
        public void get_CallbackType(){} // RVA: 0x7FFAC4BE9DB0
        public void .cctor(){} // RVA: 0x7FFAC4BE9DC0
    }

    public class GameWebCallback_t : ValueType
    {
        public byte[] CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void URLUTF8(){} // RVA: 0x7FFAC4BE9420
        public void get_CallbackType(){} // RVA: 0x7FFAC4BE9530
        public void .cctor(){} // RVA: 0x7FFAC4BE9540
    }

    public class GamepadTextInputDismissed_t : ValueType
    {
        public bool CallbackType; // 0x10
        public uint SubmittedText; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEB840
        public void .cctor(){} // RVA: 0x7FFAC4BEB850
    }

    public class GetAppDependenciesResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public Steamworks.AppId[] GAppIDs; // 0x20
        public uint NumAppDependencies; // 0x28
        public uint TotalNumAppDependencies; // 0x2C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF3150
        public void .cctor(){} // RVA: 0x7FFAC4BF3160
    }

    public class GetAuthSessionTicketResponse_t : ValueType
    {
        public uint CallbackType; // 0x10
        public 0x6B28D600 Result; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BE9310
        public void .cctor(){} // RVA: 0x7FFAC4BE9320
    }

    public class GetOPFSettingsResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.AppId VideoAppID; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF5790
        public void .cctor(){} // RVA: 0x7FFAC4BF57A0
    }

    public class GetUserItemVoteResult_t : ValueType
    {
        public Steamworks.Data.PublishedFileId CallbackType; // 0x10
        public 0x6B28D600 Result; // 0x18
        public bool VotedUp; // 0x1C
        public bool VotedDown; // 0x1D
        public bool VoteSkipped; // 0x1E
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF29E0
        public void .cctor(){} // RVA: 0x7FFAC4BF29F0
    }

    public class GetVideoURLResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.AppId VideoAppID; // 0x14
        public byte[] URL; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF5680
        public void .cctor(){} // RVA: 0x7FFAC4BF5690
    }

    public class GlobalAchievementPercentagesReady_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public 0x6B28D600 Result; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEFC30
        public void .cctor(){} // RVA: 0x7FFAC4BEFC40
    }

    public class GlobalStatsReceived_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public 0x6B28D600 Result; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEFE50
        public void .cctor(){} // RVA: 0x7FFAC4BEFE60
    }

}