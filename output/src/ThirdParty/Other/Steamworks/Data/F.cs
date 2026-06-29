// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 8
// Methods: 16

namespace ThirdParty.Other.Steamworks.Data
{
    public class FavoritesListAccountsUpdated_t : ValueType
    {
        public object Result;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147100
        public void .cctor(){} // RVA: 0x2953760
    }

    public class FavoritesListChanged_t : ValueType
    {
        public object IP;
        public object QueryPort;
        public object ConnPort;
        public object AppID;
        public object Flags;
        public object Add;
        public object AccountId;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147050
        public void .cctor(){} // RVA: 0x2952DD0
    }

    public class FileDetailsResult_t : ValueType
    {
        public object Result;
        public object FileSize;
        public object FileSHA;
        public object Flags;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C350
        public void .cctor(){} // RVA: 0x29569A0
    }

    public class FloatingGamepadTextInputDismissed_t : ValueType
    {
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147040
        public void .cctor(){} // RVA: 0x2952CF0
    }

    public class FriendRichPresenceUpdate_t : ValueType
    {
        public object SteamIDFriend;
        public object AppID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x146430
        public void .cctor(){} // RVA: 0x2951870
    }

    public class FriendsEnumerateFollowingList_t : ValueType
    {
        public object Result;
        public object GSteamID;
        public object ResultsReturned;
        public object TotalResultCount;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x146DF0
        public void .cctor(){} // RVA: 0x2952240
    }

    public class FriendsGetFollowerCount_t : ValueType
    {
        public object Result;
        public object SteamID;
        public object Count;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x146650
        public void .cctor(){} // RVA: 0x2952080
    }

    public class FriendsIsFollowing_t : ValueType
    {
        public object Result;
        public object SteamID;
        public object IsFollowing;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x146660
        public void .cctor(){} // RVA: 0x2952160
    }

}