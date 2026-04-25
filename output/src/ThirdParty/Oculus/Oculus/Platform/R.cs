// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 7
// Methods: 66

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Request : Object
    {
        public Callback RequestID; // 0x10
        public ulong <RequestID>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38920D0
        public void get_RequestID(){} // RVA: 0x7FFAC2F247C0
        public void set_RequestID(){} // RVA: 0x7FFAC38920D0
        public void OnComplete(){} // RVA: 0x7FFAC8874040
        public void HandleMessage(){} // RVA: 0x7FFAC88740F0
        public void RunCallbacks(){} // RVA: 0x7FFAC8874170
    }

    public class Request`1 : Request
    {
        public Callback<T> callback_;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70BF0
        public void OnComplete(){} // RVA: 0x7FFAC2C58F40
        public void HandleMessage(){} // RVA: 0x7FFAC2C70A40
    }

    public class RichPresence : Object
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFAC8870E30
        public void GetDestinations(){} // RVA: 0x7FFAC8870FD0
        public void Set(){} // RVA: 0x7FFAC8871180
        public void GetNextDestinationListPage(){} // RVA: 0x7FFAC8871330
    }

    public class RichPresenceOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88742C0
        public void SetApiName(){} // RVA: 0x7FFAC8874370
        public void SetCurrentCapacity(){} // RVA: 0x7FFAC88744B0
        public void SetDeeplinkMessageOverride(){} // RVA: 0x7FFAC8874570
        public void SetEndTime(){} // RVA: 0x7FFAC88746B0
        public void SetExtraContext(){} // RVA: 0x7FFAC88747C0
        public void SetInstanceId(){} // RVA: 0x7FFAC8874880
        public void SetIsIdle(){} // RVA: 0x7FFAC88749C0
        public void SetIsJoinable(){} // RVA: 0x7FFAC8874A80
        public void SetMaxCapacity(){} // RVA: 0x7FFAC8874B40
        public void SetStartTime(){} // RVA: 0x7FFAC8874C00
        public void op_Explicit(){} // RVA: 0x7FFAC8818EF0
        public void Finalize(){} // RVA: 0x7FFAC8874D10
    }

    public class RoomOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8874E00
        public void SetDataStore(){} // RVA: 0x7FFAC8874EB0
        public void ClearDataStore(){} // RVA: 0x7FFAC8875020
        public void SetExcludeRecentlyMet(){} // RVA: 0x7FFAC88750E0
        public void SetMaxUserResults(){} // RVA: 0x7FFAC88751A0
        public void SetOrdering(){} // RVA: 0x7FFAC8875260
        public void SetRecentlyMetTimeWindow(){} // RVA: 0x7FFAC8875320
        public void SetRoomId(){} // RVA: 0x7FFAC88753E0
        public void SetTurnOffUpdates(){} // RVA: 0x7FFAC88754B0
        public void op_Explicit(){} // RVA: 0x7FFAC8818EF0
        public void Finalize(){} // RVA: 0x7FFAC8875570
    }

    public class Rooms : Object
    {
        // ── Methods ──
        public void UpdateDataStore(){} // RVA: 0x7FFAC885C020
        public void SetRoomInviteNotificationCallback(){} // RVA: 0x7FFAC885C5F0
        public void CreateAndJoinPrivate(){} // RVA: 0x7FFAC885C660
        public void CreateAndJoinPrivate2(){} // RVA: 0x7FFAC885C840
        public void Get(){} // RVA: 0x7FFAC885CA20
        public void GetCurrent(){} // RVA: 0x7FFAC885CBE0
        public void GetCurrentForUser(){} // RVA: 0x7FFAC885CD90
        public void GetInvitableUsers(){} // RVA: 0x7FFAC885CF50
        public void GetInvitableUsers2(){} // RVA: 0x7FFAC885D100
        public void GetModeratedRooms(){} // RVA: 0x7FFAC885D2C0
        public void InviteUser(){} // RVA: 0x7FFAC885D470
        public void Join(){} // RVA: 0x7FFAC885D6B0
        public void Join2(){} // RVA: 0x7FFAC885D880
        public void KickUser(){} // RVA: 0x7FFAC885DA50
        public void LaunchInvitableUserFlow(){} // RVA: 0x7FFAC885DC30
        public void Leave(){} // RVA: 0x7FFAC885DDD0
        public void SetDescription(){} // RVA: 0x7FFAC885DF90
        public void UpdateMembershipLockStatus(){} // RVA: 0x7FFAC885E1D0
        public void UpdateOwner(){} // RVA: 0x7FFAC885E3A0
        public void UpdatePrivateRoomJoinPolicy(){} // RVA: 0x7FFAC885E560
        public void SetRoomInviteAcceptedNotificationCallback(){} // RVA: 0x7FFAC885C5F0
        public void SetRoomInviteReceivedNotificationCallback(){} // RVA: 0x7FFAC885E730
        public void SetUpdateNotificationCallback(){} // RVA: 0x7FFAC885E7A0
        public void GetNextRoomListPage(){} // RVA: 0x7FFAC885E810
    }

    public class RosterOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8875660
        public void AddSuggestedUser(){} // RVA: 0x7FFAC8875710
        public void ClearSuggestedUsers(){} // RVA: 0x7FFAC88757E0
        public void op_Explicit(){} // RVA: 0x7FFAC8818EF0
        public void Finalize(){} // RVA: 0x7FFAC88758A0
    }

}