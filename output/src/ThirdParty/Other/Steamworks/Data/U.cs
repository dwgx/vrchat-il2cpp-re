// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 8
// Methods: 18

namespace ThirdParty.Other.Steamworks.Data
{
    public class UnreadChatMessagesChanged_t : ValueType
    {
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E579C0
        public void .cctor(){} // RVA: 0x7FFE82E579D0
    }

    public class UserAchievementIconFetched_t : ValueType
    {
        public Steamworks.Data.GameId GameID; // 0x10

        // ── Methods ──
        public void AchievementNameUTF8(){} // RVA: 0x7FFE82E5C410
        public void get_CallbackType(){} // RVA: 0x7FFE82E5C520
        public void .cctor(){} // RVA: 0x7FFE82E5C530
    }

    public class UserAchievementStored_t : ValueType
    {
        public ulong GameID; // 0x10

        // ── Methods ──
        public void AchievementNameUTF8(){} // RVA: 0x7FFE82E5BCA0
        public void get_CallbackType(){} // RVA: 0x7FFE82E5BDB0
        public void .cctor(){} // RVA: 0x7FFE82E5BDC0
    }

    public class UserFavoriteItemsListChanged_t : ValueType
    {
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5F1C0
        public void .cctor(){} // RVA: 0x7FFE82E5F1D0
    }

    public class UserStatsReceived_t : ValueType
    {
        public ulong GameID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5BA80
        public void .cctor(){} // RVA: 0x7FFE82E5BA90
    }

    public class UserStatsStored_t : ValueType
    {
        public ulong GameID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5BB90
        public void .cctor(){} // RVA: 0x7FFE82E5BBA0
    }

    public class UserStatsUnloaded_t : ValueType
    {
        public ulong SteamIDUser; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5C300
        public void .cctor(){} // RVA: 0x7FFE82E5C310
    }

    public class UserSubscribedItemsListChanged_t : ValueType
    {
        public Steamworks.AppId AppID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFE82E5FD70
        public void .cctor(){} // RVA: 0x7FFE82E5FD80
    }

}