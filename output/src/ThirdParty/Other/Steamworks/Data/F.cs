// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 8
// Methods: 16

namespace ThirdParty.Other.Steamworks.Data
{
    public class FavoritesListAccountsUpdated_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEC710
        public void .cctor(){} // RVA: 0x7FFAC4BEC720
    }

    public class FavoritesListChanged_t : ValueType
    {
        public uint CallbackType; // 0x10
        public uint QueryPort; // 0x14
        public uint ConnPort; // 0x18
        public uint AppID; // 0x1C
        public uint Flags; // 0x20
        public bool Add; // 0x24
        public uint AccountId; // 0x28
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEBB70
        public void .cctor(){} // RVA: 0x7FFAC4BEBB80
    }

    public class FileDetailsResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public ulong FileSize; // 0x18
        public byte[] FileSHA; // 0x20
        public uint Flags; // 0x28
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF03A0
        public void .cctor(){} // RVA: 0x7FFAC4BF03B0
    }

    public class FloatingGamepadTextInputDismissed_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEBA60
        public void .cctor(){} // RVA: 0x7FFAC4BEBA70
    }

    public class FriendRichPresenceUpdate_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public Steamworks.AppId AppID; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEA1F0
        public void .cctor(){} // RVA: 0x7FFAC4BEA200
    }

    public class FriendsEnumerateFollowingList_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public ulong[] GSteamID; // 0x18
        public int ResultsReturned; // 0x20
        public int TotalResultCount; // 0x24
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEADA0
        public void .cctor(){} // RVA: 0x7FFAC4BEADB0
    }

    public class FriendsGetFollowerCount_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public ulong SteamID; // 0x14
        public int Count; // 0x1C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEAB80
        public void .cctor(){} // RVA: 0x7FFAC4BEAB90
    }

    public class FriendsIsFollowing_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public ulong SteamID; // 0x14
        public bool IsFollowing; // 0x1C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEAC90
        public void .cctor(){} // RVA: 0x7FFAC4BEACA0
    }

}