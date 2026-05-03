// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 3
// Methods: 33

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class UserDataStore : Object
    {
        // ── Methods ──
        public void PrivateDeleteEntryByKey(){} // RVA: 0x7FFE86C1ABD0
        public void PrivateGetEntries(){} // RVA: 0x7FFE86C1AE10
        public void PrivateGetEntryByKey(){} // RVA: 0x7FFE86C1AFD0
        public void PrivateWriteEntry(){} // RVA: 0x7FFE86C1B210
        public void PublicDeleteEntryByKey(){} // RVA: 0x7FFE86C1B480
        public void PublicGetEntries(){} // RVA: 0x7FFE86C1B6C0
        public void PublicGetEntryByKey(){} // RVA: 0x7FFE86C1B880
        public void PublicWriteEntry(){} // RVA: 0x7FFE86C1BAC0
    }

    public class UserOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C1F7D0
        public void SetMaxUsers(){} // RVA: 0x7FFE86C1F880
        public void AddServiceProvider(){} // RVA: 0x7FFE86C1F940
        public void ClearServiceProviders(){} // RVA: 0x7FFE86C1FA00
        public void SetTimeWindow(){} // RVA: 0x7FFE86C1FAC0
        public void op_Explicit(){} // RVA: 0x7FFE86BC25E0
        public void Finalize(){} // RVA: 0x7FFE86C1FB80
    }

    public class Users : Object
    {
        // ── Methods ──
        public void GetLoggedInUserLocale(){} // RVA: 0x7FFE86C0FE20
        public void Get(){} // RVA: 0x7FFE86C0FF90
        public void GetAccessToken(){} // RVA: 0x7FFE86C10150
        public void GetBlockedUsers(){} // RVA: 0x7FFE86C10300
        public void GetLoggedInUser(){} // RVA: 0x7FFE86C104B0
        public void GetLoggedInUserFriends(){} // RVA: 0x7FFE86C10660
        public void GetLoggedInUserFriendsAndRooms(){} // RVA: 0x7FFE86C10810
        public void GetLoggedInUserRecentlyMetUsersAndRooms(){} // RVA: 0x7FFE86C109C0
        public void GetOrgScopedID(){} // RVA: 0x7FFE86C10B80
        public void GetSdkAccounts(){} // RVA: 0x7FFE86C10D40
        public void GetUserProof(){} // RVA: 0x7FFE86C10EF0
        public void LaunchBlockFlow(){} // RVA: 0x7FFE86C110A0
        public void LaunchFriendRequestFlow(){} // RVA: 0x7FFE86C11260
        public void LaunchUnblockFlow(){} // RVA: 0x7FFE86C11420
        public void GetNextBlockedUserListPage(){} // RVA: 0x7FFE86C115E0
        public void GetNextUserAndRoomListPage(){} // RVA: 0x7FFE86C11790
        public void GetNextUserListPage(){} // RVA: 0x7FFE86C11940
        public void GetNextUserCapabilityListPage(){} // RVA: 0x7FFE86C11AF0
    }

}