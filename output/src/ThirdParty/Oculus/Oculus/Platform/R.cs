// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 7
// Methods: 66

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Request : Object
    {
        public Callback callback_; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE819EA910
        public void get_RequestID(){} // RVA: 0x7FFE810FE7C0
        public void set_RequestID(){} // RVA: 0x7FFE819EA910
        public void OnComplete(){} // RVA: 0x7FFE86C1D730
        public void HandleMessage(){} // RVA: 0x7FFE86C1D7E0
        public void RunCallbacks(){} // RVA: 0x7FFE86C1D860
    }

    public class Request`1 : Request
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E46250
        public void OnComplete(){} // RVA: 0x7FFE80E2E390
        public void HandleMessage(){} // RVA: 0x7FFE80E460A0
    }

    public class RichPresence : Object
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFE86C1A520
        public void GetDestinations(){} // RVA: 0x7FFE86C1A6C0
        public void Set(){} // RVA: 0x7FFE86C1A870
        public void GetNextDestinationListPage(){} // RVA: 0x7FFE86C1AA20
    }

    public class RichPresenceOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C1D9B0
        public void SetApiName(){} // RVA: 0x7FFE86C1DA60
        public void SetCurrentCapacity(){} // RVA: 0x7FFE86C1DBA0
        public void SetDeeplinkMessageOverride(){} // RVA: 0x7FFE86C1DC60
        public void SetEndTime(){} // RVA: 0x7FFE86C1DDA0
        public void SetExtraContext(){} // RVA: 0x7FFE86C1DEB0
        public void SetInstanceId(){} // RVA: 0x7FFE86C1DF70
        public void SetIsIdle(){} // RVA: 0x7FFE86C1E0B0
        public void SetIsJoinable(){} // RVA: 0x7FFE86C1E170
        public void SetMaxCapacity(){} // RVA: 0x7FFE86C1E230
        public void SetStartTime(){} // RVA: 0x7FFE86C1E2F0
        public void op_Explicit(){} // RVA: 0x7FFE86BC25E0
        public void Finalize(){} // RVA: 0x7FFE86C1E400
    }

    public class RoomOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C1E4F0
        public void SetDataStore(){} // RVA: 0x7FFE86C1E5A0
        public void ClearDataStore(){} // RVA: 0x7FFE86C1E710
        public void SetExcludeRecentlyMet(){} // RVA: 0x7FFE86C1E7D0
        public void SetMaxUserResults(){} // RVA: 0x7FFE86C1E890
        public void SetOrdering(){} // RVA: 0x7FFE86C1E950
        public void SetRecentlyMetTimeWindow(){} // RVA: 0x7FFE86C1EA10
        public void SetRoomId(){} // RVA: 0x7FFE86C1EAD0
        public void SetTurnOffUpdates(){} // RVA: 0x7FFE86C1EBA0
        public void op_Explicit(){} // RVA: 0x7FFE86BC25E0
        public void Finalize(){} // RVA: 0x7FFE86C1EC60
    }

    public class Rooms : Object
    {
        // ── Methods ──
        public void UpdateDataStore(){} // RVA: 0x7FFE86C05710
        public void SetRoomInviteNotificationCallback(){} // RVA: 0x7FFE86C05CE0
        public void CreateAndJoinPrivate(){} // RVA: 0x7FFE86C05D50
        public void CreateAndJoinPrivate2(){} // RVA: 0x7FFE86C05F30
        public void Get(){} // RVA: 0x7FFE86C06110
        public void GetCurrent(){} // RVA: 0x7FFE86C062D0
        public void GetCurrentForUser(){} // RVA: 0x7FFE86C06480
        public void GetInvitableUsers(){} // RVA: 0x7FFE86C06640
        public void GetInvitableUsers2(){} // RVA: 0x7FFE86C067F0
        public void GetModeratedRooms(){} // RVA: 0x7FFE86C069B0
        public void InviteUser(){} // RVA: 0x7FFE86C06B60
        public void Join(){} // RVA: 0x7FFE86C06DA0
        public void Join2(){} // RVA: 0x7FFE86C06F70
        public void KickUser(){} // RVA: 0x7FFE86C07140
        public void LaunchInvitableUserFlow(){} // RVA: 0x7FFE86C07320
        public void Leave(){} // RVA: 0x7FFE86C074C0
        public void SetDescription(){} // RVA: 0x7FFE86C07680
        public void UpdateMembershipLockStatus(){} // RVA: 0x7FFE86C078C0
        public void UpdateOwner(){} // RVA: 0x7FFE86C07A90
        public void UpdatePrivateRoomJoinPolicy(){} // RVA: 0x7FFE86C07C50
        public void SetRoomInviteAcceptedNotificationCallback(){} // RVA: 0x7FFE86C05CE0
        public void SetRoomInviteReceivedNotificationCallback(){} // RVA: 0x7FFE86C07E20
        public void SetUpdateNotificationCallback(){} // RVA: 0x7FFE86C07E90
        public void GetNextRoomListPage(){} // RVA: 0x7FFE86C07F00
    }

    public class RosterOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C1ED50
        public void AddSuggestedUser(){} // RVA: 0x7FFE86C1EE00
        public void ClearSuggestedUsers(){} // RVA: 0x7FFE86C1EED0
        public void op_Explicit(){} // RVA: 0x7FFE86BC25E0
        public void Finalize(){} // RVA: 0x7FFE86C1EF90
    }

}