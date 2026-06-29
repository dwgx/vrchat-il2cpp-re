// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 5
// Methods: 5

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class RejoinDialogResult : Object
    {
        public object RejoinSelected;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B64030
    }

    public class Room : Object
    {
        public object ApplicationID;
        public object DataStore;
        public object Description;
        public object ID;
        public object InvitedUsersOptional;
        public object InvitedUsers;
        public object IsMembershipLocked;
        public object JoinPolicy;
        public object Joinability;
        public object MatchedUsersOptional;
        public object MatchedUsers;
        public object MaxUsers;
        public object Name;
        public object OwnerOptional;
        public object Owner;
        public object TeamsOptional;
        public object Teams;
        public object Type;
        public object UsersOptional;
        public object Users;
        public object Version;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B64100
    }

    public class RoomInviteNotification : Object
    {
        public object ID;
        public object RoomID;
        public object SenderID;
        public object SentTime;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B65300
    }

    public class RoomInviteNotificationList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B65530
    }

    public class RoomList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B64F20
    }

}