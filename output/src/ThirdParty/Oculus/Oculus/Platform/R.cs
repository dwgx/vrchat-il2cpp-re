// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 7
// Methods: 66

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Request : Object
    {
        public object callback_;
        public object _requestID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x15428E0
        public void get_RequestID(){} // RVA: 0xB465B0
        public void set_RequestID(){} // RVA: 0x15428E0
        public void OnComplete(){} // RVA: 0x6B4FE50
        public void HandleMessage(){} // RVA: 0x6B4FF00
        public void RunCallbacks(){} // RVA: 0x6B4FF80
    }

    public class Request`1 : Request
    {
        public object callback_;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8943F0
        public void OnComplete(){} // RVA: 0x87C540
        public void HandleMessage(){} // RVA: 0x894320
    }

    public class RichPresence : Object
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x6B4CC00
        public void GetDestinations(){} // RVA: 0x6B4CDA0
        public void Set(){} // RVA: 0x6B4CF50
        public void GetNextDestinationListPage(){} // RVA: 0x6B4D100
    }

    public class RichPresenceOptions : Object
    {
        public object Handle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B500D0
        public void SetApiName(){} // RVA: 0x6B50180
        public void SetCurrentCapacity(){} // RVA: 0x6B502C0
        public void SetDeeplinkMessageOverride(){} // RVA: 0x6B50380
        public void SetEndTime(){} // RVA: 0x6B504C0
        public void SetExtraContext(){} // RVA: 0x6B505D0
        public void SetInstanceId(){} // RVA: 0x6B50690
        public void SetIsIdle(){} // RVA: 0x6B507D0
        public void SetIsJoinable(){} // RVA: 0x6B50890
        public void SetMaxCapacity(){} // RVA: 0x6B50950
        public void SetStartTime(){} // RVA: 0x6B50A10
        public void op_Explicit(){} // RVA: 0x6AF4C10
        public void Finalize(){} // RVA: 0x6B50B20
    }

    public class RoomOptions : Object
    {
        public object Handle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B50C10
        public void SetDataStore(){} // RVA: 0x6B50CC0
        public void ClearDataStore(){} // RVA: 0x6B50E30
        public void SetExcludeRecentlyMet(){} // RVA: 0x6B50EF0
        public void SetMaxUserResults(){} // RVA: 0x6B50FB0
        public void SetOrdering(){} // RVA: 0x6B51070
        public void SetRecentlyMetTimeWindow(){} // RVA: 0x6B51130
        public void SetRoomId(){} // RVA: 0x6B511F0
        public void SetTurnOffUpdates(){} // RVA: 0x6B512C0
        public void op_Explicit(){} // RVA: 0x6AF4C10
        public void Finalize(){} // RVA: 0x6B51380
    }

    public class Rooms : Object
    {
        // ── Methods ──
        public void UpdateDataStore(){} // RVA: 0x6B37DC0
        public void SetRoomInviteNotificationCallback(){} // RVA: 0x6B383A0
        public void CreateAndJoinPrivate(){} // RVA: 0x6B38410
        public void CreateAndJoinPrivate2(){} // RVA: 0x6B385F0
        public void Get(){} // RVA: 0x6B387D0
        public void GetCurrent(){} // RVA: 0x6B38990
        public void GetCurrentForUser(){} // RVA: 0x6B38B40
        public void GetInvitableUsers(){} // RVA: 0x6B38D00
        public void GetInvitableUsers2(){} // RVA: 0x6B38EB0
        public void GetModeratedRooms(){} // RVA: 0x6B39070
        public void InviteUser(){} // RVA: 0x6B39220
        public void Join(){} // RVA: 0x6B39460
        public void Join2(){} // RVA: 0x6B39630
        public void KickUser(){} // RVA: 0x6B39800
        public void LaunchInvitableUserFlow(){} // RVA: 0x6B399E0
        public void Leave(){} // RVA: 0x6B39B80
        public void SetDescription(){} // RVA: 0x6B39D40
        public void UpdateMembershipLockStatus(){} // RVA: 0x6B39F80
        public void UpdateOwner(){} // RVA: 0x6B3A150
        public void UpdatePrivateRoomJoinPolicy(){} // RVA: 0x6B3A310
        public void SetRoomInviteAcceptedNotificationCallback(){} // RVA: 0x6B383A0
        public void SetRoomInviteReceivedNotificationCallback(){} // RVA: 0x6B3A4E0
        public void SetUpdateNotificationCallback(){} // RVA: 0x6B3A550
        public void GetNextRoomListPage(){} // RVA: 0x6B3A5C0
    }

    public class RosterOptions : Object
    {
        public object Handle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B51470
        public void AddSuggestedUser(){} // RVA: 0x6B51520
        public void ClearSuggestedUsers(){} // RVA: 0x6B515F0
        public void op_Explicit(){} // RVA: 0x6AF4C10
        public void Finalize(){} // RVA: 0x6B516B0
    }

}