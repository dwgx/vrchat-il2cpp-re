// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 3
// Methods: 33

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class UserDataStore
    {
        // ── Methods ──
        public void PrivateDeleteEntryByKey(){} // RVA: 0x60D9E00
        public void PrivateGetEntries(){} // RVA: 0x60DA040
        public void PrivateGetEntryByKey(){} // RVA: 0x60DA200
        public void PrivateWriteEntry(){} // RVA: 0x60DA440
        public void PublicDeleteEntryByKey(){} // RVA: 0x60DA6B0
        public void PublicGetEntries(){} // RVA: 0x60DA8F0
        public void PublicGetEntryByKey(){} // RVA: 0x60DAAB0
        public void PublicWriteEntry(){} // RVA: 0x60DACF0
    }

    public class UserOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60DEA00
        public void SetMaxUsers(){} // RVA: 0x60DEAB0
        public void AddServiceProvider(){} // RVA: 0x60DEB70
        public void ClearServiceProviders(){} // RVA: 0x60DEC30
        public void SetTimeWindow(){} // RVA: 0x60DECF0
        public void op_Explicit(){} // RVA: 0x6081810
        public void Finalize(){} // RVA: 0x60DEDB0
    }

    public class Users
    {
        // ── Methods ──
        public void GetLoggedInUserLocale(){} // RVA: 0x60CF050
        public void Get(){} // RVA: 0x60CF1C0
        public void GetAccessToken(){} // RVA: 0x60CF380
        public void GetBlockedUsers(){} // RVA: 0x60CF530
        public void GetLoggedInUser(){} // RVA: 0x60CF6E0
        public void GetLoggedInUserFriends(){} // RVA: 0x60CF890
        public void GetLoggedInUserFriendsAndRooms(){} // RVA: 0x60CFA40
        public void GetLoggedInUserRecentlyMetUsersAndRooms(){} // RVA: 0x60CFBF0
        public void GetOrgScopedID(){} // RVA: 0x60CFDB0
        public void GetSdkAccounts(){} // RVA: 0x60CFF70
        public void GetUserProof(){} // RVA: 0x60D0120
        public void LaunchBlockFlow(){} // RVA: 0x60D02D0
        public void LaunchFriendRequestFlow(){} // RVA: 0x60D0490
        public void LaunchUnblockFlow(){} // RVA: 0x60D0650
        public void GetNextBlockedUserListPage(){} // RVA: 0x60D0810
        public void GetNextUserAndRoomListPage(){} // RVA: 0x60D09C0
        public void GetNextUserListPage(){} // RVA: 0x60D0B70
        public void GetNextUserCapabilityListPage(){} // RVA: 0x60D0D20
    }

}