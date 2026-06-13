// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 7
// Methods: 66

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Request
    {
        public Callback callback_; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC5BE60
        public void get_RequestID(){} // RVA: 0x2E07C0
        public void set_RequestID(){} // RVA: 0xC5BE60
        public void OnComplete(){} // RVA: 0x60DC960
        public void HandleMessage(){} // RVA: 0x60DCA10
        public void RunCallbacks(){} // RVA: 0x60DCA90
    }

    public class Request`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24CC0
        public void OnComplete(){} // RVA: 0xCE10
        public void HandleMessage(){} // RVA: 0x24B10
    }

    public class RichPresence
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x60D9750
        public void GetDestinations(){} // RVA: 0x60D98F0
        public void Set(){} // RVA: 0x60D9AA0
        public void GetNextDestinationListPage(){} // RVA: 0x60D9C50
    }

    public class RichPresenceOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60DCBE0
        public void SetApiName(){} // RVA: 0x60DCC90
        public void SetCurrentCapacity(){} // RVA: 0x60DCDD0
        public void SetDeeplinkMessageOverride(){} // RVA: 0x60DCE90
        public void SetEndTime(){} // RVA: 0x60DCFD0
        public void SetExtraContext(){} // RVA: 0x60DD0E0
        public void SetInstanceId(){} // RVA: 0x60DD1A0
        public void SetIsIdle(){} // RVA: 0x60DD2E0
        public void SetIsJoinable(){} // RVA: 0x60DD3A0
        public void SetMaxCapacity(){} // RVA: 0x60DD460
        public void SetStartTime(){} // RVA: 0x60DD520
        public void op_Explicit(){} // RVA: 0x6081810
        public void Finalize(){} // RVA: 0x60DD630
    }

    public class RoomOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60DD720
        public void SetDataStore(){} // RVA: 0x60DD7D0
        public void ClearDataStore(){} // RVA: 0x60DD940
        public void SetExcludeRecentlyMet(){} // RVA: 0x60DDA00
        public void SetMaxUserResults(){} // RVA: 0x60DDAC0
        public void SetOrdering(){} // RVA: 0x60DDB80
        public void SetRecentlyMetTimeWindow(){} // RVA: 0x60DDC40
        public void SetRoomId(){} // RVA: 0x60DDD00
        public void SetTurnOffUpdates(){} // RVA: 0x60DDDD0
        public void op_Explicit(){} // RVA: 0x6081810
        public void Finalize(){} // RVA: 0x60DDE90
    }

    public class Rooms
    {
        // ── Methods ──
        public void UpdateDataStore(){} // RVA: 0x60C4940
        public void SetRoomInviteNotificationCallback(){} // RVA: 0x60C4F10
        public void CreateAndJoinPrivate(){} // RVA: 0x60C4F80
        public void CreateAndJoinPrivate2(){} // RVA: 0x60C5160
        public void Get(){} // RVA: 0x60C5340
        public void GetCurrent(){} // RVA: 0x60C5500
        public void GetCurrentForUser(){} // RVA: 0x60C56B0
        public void GetInvitableUsers(){} // RVA: 0x60C5870
        public void GetInvitableUsers2(){} // RVA: 0x60C5A20
        public void GetModeratedRooms(){} // RVA: 0x60C5BE0
        public void InviteUser(){} // RVA: 0x60C5D90
        public void Join(){} // RVA: 0x60C5FD0
        public void Join2(){} // RVA: 0x60C61A0
        public void KickUser(){} // RVA: 0x60C6370
        public void LaunchInvitableUserFlow(){} // RVA: 0x60C6550
        public void Leave(){} // RVA: 0x60C66F0
        public void SetDescription(){} // RVA: 0x60C68B0
        public void UpdateMembershipLockStatus(){} // RVA: 0x60C6AF0
        public void UpdateOwner(){} // RVA: 0x60C6CC0
        public void UpdatePrivateRoomJoinPolicy(){} // RVA: 0x60C6E80
        public void SetRoomInviteAcceptedNotificationCallback(){} // RVA: 0x60C4F10
        public void SetRoomInviteReceivedNotificationCallback(){} // RVA: 0x60C7050
        public void SetUpdateNotificationCallback(){} // RVA: 0x60C70C0
        public void GetNextRoomListPage(){} // RVA: 0x60C7130
    }

    public class RosterOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60DDF80
        public void AddSuggestedUser(){} // RVA: 0x60DE030
        public void ClearSuggestedUsers(){} // RVA: 0x60DE100
        public void op_Explicit(){} // RVA: 0x6081810
        public void Finalize(){} // RVA: 0x60DE1C0
    }

}