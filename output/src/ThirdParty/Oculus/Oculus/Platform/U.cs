// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 3
// Methods: 33

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class UserDataStore : Object
    {
        // ── Methods ──
        public void PrivateDeleteEntryByKey(){} // RVA: 0x7FFAC88714E0
        public void PrivateGetEntries(){} // RVA: 0x7FFAC8871720
        public void PrivateGetEntryByKey(){} // RVA: 0x7FFAC88718E0
        public void PrivateWriteEntry(){} // RVA: 0x7FFAC8871B20
        public void PublicDeleteEntryByKey(){} // RVA: 0x7FFAC8871D90
        public void PublicGetEntries(){} // RVA: 0x7FFAC8871FD0
        public void PublicGetEntryByKey(){} // RVA: 0x7FFAC8872190
        public void PublicWriteEntry(){} // RVA: 0x7FFAC88723D0
    }

    public class UserOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88760E0
        public void SetMaxUsers(){} // RVA: 0x7FFAC8876190
        public void AddServiceProvider(){} // RVA: 0x7FFAC8876250
        public void ClearServiceProviders(){} // RVA: 0x7FFAC8876310
        public void SetTimeWindow(){} // RVA: 0x7FFAC88763D0
        public void op_Explicit(){} // RVA: 0x7FFAC8818EF0
        public void Finalize(){} // RVA: 0x7FFAC8876490
    }

    public class Users : Object
    {
        // ── Methods ──
        public void GetLoggedInUserLocale(){} // RVA: 0x7FFAC8866730
        public void Get(){} // RVA: 0x7FFAC88668A0
        public void GetAccessToken(){} // RVA: 0x7FFAC8866A60
        public void GetBlockedUsers(){} // RVA: 0x7FFAC8866C10
        public void GetLoggedInUser(){} // RVA: 0x7FFAC8866DC0
        public void GetLoggedInUserFriends(){} // RVA: 0x7FFAC8866F70
        public void GetLoggedInUserFriendsAndRooms(){} // RVA: 0x7FFAC8867120
        public void GetLoggedInUserRecentlyMetUsersAndRooms(){} // RVA: 0x7FFAC88672D0
        public void GetOrgScopedID(){} // RVA: 0x7FFAC8867490
        public void GetSdkAccounts(){} // RVA: 0x7FFAC8867650
        public void GetUserProof(){} // RVA: 0x7FFAC8867800
        public void LaunchBlockFlow(){} // RVA: 0x7FFAC88679B0
        public void LaunchFriendRequestFlow(){} // RVA: 0x7FFAC8867B70
        public void LaunchUnblockFlow(){} // RVA: 0x7FFAC8867D30
        public void GetNextBlockedUserListPage(){} // RVA: 0x7FFAC8867EF0
        public void GetNextUserAndRoomListPage(){} // RVA: 0x7FFAC88680A0
        public void GetNextUserListPage(){} // RVA: 0x7FFAC8868250
        public void GetNextUserCapabilityListPage(){} // RVA: 0x7FFAC8868400
    }

}