// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 7
// Methods: 70

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Request : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8A224D0
        public void get_RequestID(){} // RVA: 0x7A80DA7B0
        public void set_RequestID(){} // RVA: 0x7A8A224D0
        public void OnComplete(){} // RVA: 0x7ADEC8C50
        public void HandleMessage(){} // RVA: 0x7ADEC8D00
        public void RunCallbacks(){} // RVA: 0x7ADEC8D80
        public void callback_(){} // RVA: 0x7B4194918
    }

    public class Request`1 : Request
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E188D0
        public void OnComplete(){} // RVA: 0x7A7E00B20
        public void HandleMessage(){} // RVA: 0x7A7E18800
    }

    public class RichPresence : Object
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7ADEC5A40
        public void GetDestinations(){} // RVA: 0x7ADEC5BE0
        public void Set(){} // RVA: 0x7ADEC5D90
        public void GetNextDestinationListPage(){} // RVA: 0x7ADEC5F40
    }

    public class RichPresenceOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEC8ED0
        public void SetApiName(){} // RVA: 0x7ADEC8F80
        public void SetCurrentCapacity(){} // RVA: 0x7ADEC90C0
        public void SetDeeplinkMessageOverride(){} // RVA: 0x7ADEC9180
        public void SetEndTime(){} // RVA: 0x7ADEC92C0
        public void SetExtraContext(){} // RVA: 0x7ADEC93D0
        public void SetInstanceId(){} // RVA: 0x7ADEC9490
        public void SetIsIdle(){} // RVA: 0x7ADEC95D0
        public void SetIsJoinable(){} // RVA: 0x7ADEC9690
        public void SetMaxCapacity(){} // RVA: 0x7ADEC9750
        public void SetStartTime(){} // RVA: 0x7ADEC9810
        public void op_Explicit(){} // RVA: 0x7ADE6D8D0
        public void Finalize(){} // RVA: 0x7ADEC9920
        public void Handle(){} // RVA: 0x7B3FA9088
    }

    public class RoomOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEC9A10
        public void SetDataStore(){} // RVA: 0x7ADEC9AC0
        public void ClearDataStore(){} // RVA: 0x7ADEC9C30
        public void SetExcludeRecentlyMet(){} // RVA: 0x7ADEC9CF0
        public void SetMaxUserResults(){} // RVA: 0x7ADEC9DB0
        public void SetOrdering(){} // RVA: 0x7ADEC9E70
        public void SetRecentlyMetTimeWindow(){} // RVA: 0x7ADEC9F30
        public void SetRoomId(){} // RVA: 0x7ADEC9FF0
        public void SetTurnOffUpdates(){} // RVA: 0x7ADECA0C0
        public void op_Explicit(){} // RVA: 0x7ADE6D8D0
        public void Finalize(){} // RVA: 0x7ADECA180
        public void Handle(){} // RVA: 0x7B3FAD508
    }

    public class Rooms : Object
    {
        // ── Methods ──
        public void UpdateDataStore(){} // RVA: 0x7ADEB0C00
        public void SetRoomInviteNotificationCallback(){} // RVA: 0x7ADEB11E0
        public void CreateAndJoinPrivate(){} // RVA: 0x7ADEB1250
        public void CreateAndJoinPrivate2(){} // RVA: 0x7ADEB1430
        public void Get(){} // RVA: 0x7ADEB1610
        public void GetCurrent(){} // RVA: 0x7ADEB17D0
        public void GetCurrentForUser(){} // RVA: 0x7ADEB1980
        public void GetInvitableUsers(){} // RVA: 0x7ADEB1B40
        public void GetInvitableUsers2(){} // RVA: 0x7ADEB1CF0
        public void GetModeratedRooms(){} // RVA: 0x7ADEB1EB0
        public void InviteUser(){} // RVA: 0x7ADEB2060
        public void Join(){} // RVA: 0x7ADEB22A0
        public void Join2(){} // RVA: 0x7ADEB2470
        public void KickUser(){} // RVA: 0x7ADEB2640
        public void LaunchInvitableUserFlow(){} // RVA: 0x7ADEB2820
        public void Leave(){} // RVA: 0x7ADEB29C0
        public void SetDescription(){} // RVA: 0x7ADEB2B80
        public void UpdateMembershipLockStatus(){} // RVA: 0x7ADEB2DC0
        public void UpdateOwner(){} // RVA: 0x7ADEB2F90
        public void UpdatePrivateRoomJoinPolicy(){} // RVA: 0x7ADEB3150
        public void SetRoomInviteAcceptedNotificationCallback(){} // RVA: 0x7ADEB11E0
        public void SetRoomInviteReceivedNotificationCallback(){} // RVA: 0x7ADEB3320
        public void SetUpdateNotificationCallback(){} // RVA: 0x7ADEB3390
        public void GetNextRoomListPage(){} // RVA: 0x7ADEB3400
    }

    public class RosterOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADECA270
        public void AddSuggestedUser(){} // RVA: 0x7ADECA320
        public void ClearSuggestedUsers(){} // RVA: 0x7ADECA3F0
        public void op_Explicit(){} // RVA: 0x7ADE6D8D0
        public void Finalize(){} // RVA: 0x7ADECA4B0
        public void Handle(){} // RVA: 0x7B3FA6FC8
    }

}