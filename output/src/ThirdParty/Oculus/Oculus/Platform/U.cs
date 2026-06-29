// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 3
// Methods: 33

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class UserDataStore : Object
    {
        // ── Methods ──
        public void PrivateDeleteEntryByKey(){} // RVA: 0x6B4D2B0
        public void PrivateGetEntries(){} // RVA: 0x6B4D4F0
        public void PrivateGetEntryByKey(){} // RVA: 0x6B4D6B0
        public void PrivateWriteEntry(){} // RVA: 0x6B4D8F0
        public void PublicDeleteEntryByKey(){} // RVA: 0x6B4DB60
        public void PublicGetEntries(){} // RVA: 0x6B4DDA0
        public void PublicGetEntryByKey(){} // RVA: 0x6B4DF60
        public void PublicWriteEntry(){} // RVA: 0x6B4E1A0
    }

    public class UserOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B51DB0
        public void SetMaxUsers(){} // RVA: 0x6B51E60
        public void AddServiceProvider(){} // RVA: 0x6B51F20
        public void ClearServiceProviders(){} // RVA: 0x6B51FE0
        public void SetTimeWindow(){} // RVA: 0x6B520A0
        public void op_Explicit(){} // RVA: 0x6AF4C10
        public void Finalize(){} // RVA: 0x6B52160
    }

    public class Users : Object
    {
        // ── Methods ──
        public void GetLoggedInUserLocale(){} // RVA: 0x6B424F0
        public void Get(){} // RVA: 0x6B42660
        public void GetAccessToken(){} // RVA: 0x6B42820
        public void GetBlockedUsers(){} // RVA: 0x6B429D0
        public void GetLoggedInUser(){} // RVA: 0x6B42B80
        public void GetLoggedInUserFriends(){} // RVA: 0x6B42D30
        public void GetLoggedInUserFriendsAndRooms(){} // RVA: 0x6B42EE0
        public void GetLoggedInUserRecentlyMetUsersAndRooms(){} // RVA: 0x6B43090
        public void GetOrgScopedID(){} // RVA: 0x6B43250
        public void GetSdkAccounts(){} // RVA: 0x6B43410
        public void GetUserProof(){} // RVA: 0x6B435C0
        public void LaunchBlockFlow(){} // RVA: 0x6B43770
        public void LaunchFriendRequestFlow(){} // RVA: 0x6B43930
        public void LaunchUnblockFlow(){} // RVA: 0x6B43AF0
        public void GetNextBlockedUserListPage(){} // RVA: 0x6B43CB0
        public void GetNextUserAndRoomListPage(){} // RVA: 0x6B43E60
        public void GetNextUserListPage(){} // RVA: 0x6B44010
        public void GetNextUserCapabilityListPage(){} // RVA: 0x6B441C0
    }

}