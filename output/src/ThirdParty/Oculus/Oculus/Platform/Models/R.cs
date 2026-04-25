// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 5
// Methods: 5

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class RejoinDialogResult : Object
    {
        public bool RejoinSelected; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88884A0
    }

    public class Room : Object
    {
        public ulong ApplicationID; // 0x10
        public System.Collections.Generic.Dictionary`2<string,string> DataStore; // 0x18
        public string Description; // 0x20
        public ulong ID; // 0x28
        public Oculus.Platform.Models.UserList InvitedUsersOptional; // 0x30
        public Oculus.Platform.Models.UserList InvitedUsers; // 0x38
        public bool IsMembershipLocked; // 0x40
        public 0x6B258860 JoinPolicy; // 0x44
        public 0x6B258808 Joinability; // 0x48
        public Oculus.Platform.Models.MatchmakingEnqueuedUserList MatchedUsersOptional; // 0x50
        public Oculus.Platform.Models.MatchmakingEnqueuedUserList MatchedUsers; // 0x58
        public uint MaxUsers; // 0x60
        public string Name; // 0x68
        public Oculus.Platform.Models.User OwnerOptional; // 0x70
        public Oculus.Platform.Models.User Owner; // 0x78
        public Oculus.Platform.Models.TeamList TeamsOptional; // 0x80
        public Oculus.Platform.Models.TeamList Teams; // 0x88
        public 0x6B258968 Type; // 0x90
        public Oculus.Platform.Models.UserList UsersOptional; // 0x98
        public Oculus.Platform.Models.UserList Users; // 0xA0
        public uint Version; // 0xA8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8888570
    }

    public class RoomInviteNotification : Object
    {
        public ulong ID; // 0x10
        public ulong RoomID; // 0x18
        public ulong SenderID; // 0x20
        public System.DateTime SentTime; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8889780
    }

    public class RoomInviteNotificationList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88899B0
    }

    public class RoomList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8889390
    }

}