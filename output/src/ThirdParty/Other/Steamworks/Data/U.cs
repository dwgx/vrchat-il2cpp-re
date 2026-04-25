// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 8
// Methods: 18

namespace ThirdParty.Other.Steamworks.Data
{
    public class UnreadChatMessagesChanged_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEAFC0
        public void .cctor(){} // RVA: 0x7FFAC4BEAFD0
    }

    public class UserAchievementIconFetched_t : ValueType
    {
        public Steamworks.Data.GameId CallbackType; // 0x10
        public byte[] AchievementName; // 0x18
        public bool Achieved; // 0x20
        public int IconHandle; // 0x24
        public int _datasize;

        // ── Methods ──
        public void AchievementNameUTF8(){} // RVA: 0x7FFAC4BEFA10
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEFB20
        public void .cctor(){} // RVA: 0x7FFAC4BEFB30
    }

    public class UserAchievementStored_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public bool GroupAchievement; // 0x18
        public byte[] AchievementName; // 0x20
        public uint CurProgress; // 0x28
        public uint MaxProgress; // 0x2C
        public int _datasize;

        // ── Methods ──
        public void AchievementNameUTF8(){} // RVA: 0x7FFAC4BEF2A0
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEF3B0
        public void .cctor(){} // RVA: 0x7FFAC4BEF3C0
    }

    public class UserFavoriteItemsListChanged_t : ValueType
    {
        public Steamworks.Data.PublishedFileId CallbackType; // 0x10
        public 0x6B28D600 Result; // 0x18
        public bool WasAddRequest; // 0x1C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF27C0
        public void .cctor(){} // RVA: 0x7FFAC4BF27D0
    }

    public class UserStatsReceived_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public 0x6B28D600 Result; // 0x18
        public ulong SteamIDUser; // 0x1C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEF080
        public void .cctor(){} // RVA: 0x7FFAC4BEF090
    }

    public class UserStatsStored_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public 0x6B28D600 Result; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEF190
        public void .cctor(){} // RVA: 0x7FFAC4BEF1A0
    }

    public class UserStatsUnloaded_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEF900
        public void .cctor(){} // RVA: 0x7FFAC4BEF910
    }

    public class UserSubscribedItemsListChanged_t : ValueType
    {
        public Steamworks.AppId CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF3370
        public void .cctor(){} // RVA: 0x7FFAC4BF3380
    }

}