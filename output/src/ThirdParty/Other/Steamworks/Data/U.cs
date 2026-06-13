// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 8
// Methods: 18

namespace ThirdParty.Other.Steamworks.Data
{
    public class UnreadChatMessagesChanged_t
    {
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20C95C0
        public void .cctor(){} // RVA: 0x20C95D0
    }

    public class UserAchievementIconFetched_t
    {
        public Steamworks.Data.GameId GameID; // 0x10

        // ── Methods ──
        public void AchievementNameUTF8(){} // RVA: 0x20CE010
        public void get_CallbackType(){} // RVA: 0x20CE120
        public void .cctor(){} // RVA: 0x20CE130
    }

    public class UserAchievementStored_t
    {
        public ulong GameID; // 0x10

        // ── Methods ──
        public void AchievementNameUTF8(){} // RVA: 0x20CD8A0
        public void get_CallbackType(){} // RVA: 0x20CD9B0
        public void .cctor(){} // RVA: 0x20CD9C0
    }

    public class UserFavoriteItemsListChanged_t
    {
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D0DC0
        public void .cctor(){} // RVA: 0x20D0DD0
    }

    public class UserStatsReceived_t
    {
        public ulong GameID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20CD680
        public void .cctor(){} // RVA: 0x20CD690
    }

    public class UserStatsStored_t
    {
        public ulong GameID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20CD790
        public void .cctor(){} // RVA: 0x20CD7A0
    }

    public class UserStatsUnloaded_t
    {
        public ulong SteamIDUser; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20CDF00
        public void .cctor(){} // RVA: 0x20CDF10
    }

    public class UserSubscribedItemsListChanged_t
    {
        public Steamworks.AppId AppID; // 0x10

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x20D1970
        public void .cctor(){} // RVA: 0x20D1980
    }

}