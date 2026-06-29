// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 8
// Methods: 18

namespace ThirdParty.Other.Steamworks.Data
{
    public class UnreadChatMessagesChanged_t : ValueType
    {
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x146E10
        public void .cctor(){} // RVA: 0x2952400
    }

    public class UserAchievementIconFetched_t : ValueType
    {
        public object GameID;
        public object AchievementName;
        public object Achieved;
        public object IconHandle;
        public object _datasize;

        // ── Methods ──
        public void AchievementNameUTF8(){} // RVA: 0x14BE10
        public void get_CallbackType(){} // RVA: 0x14BE20
        public void .cctor(){} // RVA: 0x29562A0
    }

    public class UserAchievementStored_t : ValueType
    {
        public object GameID;
        public object GroupAchievement;
        public object AchievementName;
        public object CurProgress;
        public object MaxProgress;
        public object _datasize;

        // ── Methods ──
        public void AchievementNameUTF8(){} // RVA: 0x14BA90
        public void get_CallbackType(){} // RVA: 0x14BAA0
        public void .cctor(){} // RVA: 0x2955C50
    }

    public class UserFavoriteItemsListChanged_t : ValueType
    {
        public object PublishedFileId;
        public object Result;
        public object WasAddRequest;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C880
        public void .cctor(){} // RVA: 0x2958760
    }

    public class UserStatsReceived_t : ValueType
    {
        public object GameID;
        public object Result;
        public object SteamIDUser;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14B750
        public void .cctor(){} // RVA: 0x2955980
    }

    public class UserStatsStored_t : ValueType
    {
        public object GameID;
        public object Result;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14B760
        public void .cctor(){} // RVA: 0x2955A60
    }

    public class UserStatsUnloaded_t : ValueType
    {
        public object SteamIDUser;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14BAF0
        public void .cctor(){} // RVA: 0x29560B0
    }

    public class UserSubscribedItemsListChanged_t : ValueType
    {
        public object AppID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14CD30
        public void .cctor(){} // RVA: 0x2959100
    }

}