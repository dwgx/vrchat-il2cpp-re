// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 3
// Methods: 34

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class UserDataStore : Object
    {
        // ── Methods ──
        public void PrivateDeleteEntryByKey(){} // RVA: 0x7ADEC60F0
        public void PrivateGetEntries(){} // RVA: 0x7ADEC6330
        public void PrivateGetEntryByKey(){} // RVA: 0x7ADEC64F0
        public void PrivateWriteEntry(){} // RVA: 0x7ADEC6730
        public void PublicDeleteEntryByKey(){} // RVA: 0x7ADEC69A0
        public void PublicGetEntries(){} // RVA: 0x7ADEC6BE0
        public void PublicGetEntryByKey(){} // RVA: 0x7ADEC6DA0
        public void PublicWriteEntry(){} // RVA: 0x7ADEC6FE0
    }

    public class UserOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADECACF0
        public void SetMaxUsers(){} // RVA: 0x7ADECADA0
        public void AddServiceProvider(){} // RVA: 0x7ADECAE60
        public void ClearServiceProviders(){} // RVA: 0x7ADECAF20
        public void SetTimeWindow(){} // RVA: 0x7ADECAFE0
        public void op_Explicit(){} // RVA: 0x7ADE6D8D0
        public void Finalize(){} // RVA: 0x7ADECB0A0
        public void Handle(){} // RVA: 0x7B417F398
    }

    public class Users : Object
    {
        // ── Methods ──
        public void GetLoggedInUserLocale(){} // RVA: 0x7ADEBB330
        public void Get(){} // RVA: 0x7ADEBB4A0
        public void GetAccessToken(){} // RVA: 0x7ADEBB660
        public void GetBlockedUsers(){} // RVA: 0x7ADEBB810
        public void GetLoggedInUser(){} // RVA: 0x7ADEBB9C0
        public void GetLoggedInUserFriends(){} // RVA: 0x7ADEBBB70
        public void GetLoggedInUserFriendsAndRooms(){} // RVA: 0x7ADEBBD20
        public void GetLoggedInUserRecentlyMetUsersAndRooms(){} // RVA: 0x7ADEBBED0
        public void GetOrgScopedID(){} // RVA: 0x7ADEBC090
        public void GetSdkAccounts(){} // RVA: 0x7ADEBC250
        public void GetUserProof(){} // RVA: 0x7ADEBC400
        public void LaunchBlockFlow(){} // RVA: 0x7ADEBC5B0
        public void LaunchFriendRequestFlow(){} // RVA: 0x7ADEBC770
        public void LaunchUnblockFlow(){} // RVA: 0x7ADEBC930
        public void GetNextBlockedUserListPage(){} // RVA: 0x7ADEBCAF0
        public void GetNextUserAndRoomListPage(){} // RVA: 0x7ADEBCCA0
        public void GetNextUserListPage(){} // RVA: 0x7ADEBCE50
        public void GetNextUserCapabilityListPage(){} // RVA: 0x7ADEBD000
    }

}