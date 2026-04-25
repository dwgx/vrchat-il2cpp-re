// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 9
// Methods: 9

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class User : Object
    {
        public string DisplayName; // 0x10
        public ulong ID; // 0x18
        public string ImageURL; // 0x20
        public string InviteToken; // 0x28
        public string OculusID; // 0x30
        public string Presence; // 0x38
        public string PresenceDeeplinkMessage; // 0x40
        public string PresenceDestinationApiName; // 0x48
        public string PresenceLobbySessionId; // 0x50
        public string PresenceMatchSessionId; // 0x58
        public 0x6B258DE0 PresenceStatus; // 0x60
        public string SmallImageUrl; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC888ACE0
    }

    public class UserAndRoom : Object
    {
        public Oculus.Platform.Models.Room RoomOptional; // 0x10
        public Oculus.Platform.Models.Room Room; // 0x18
        public Oculus.Platform.Models.User User; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC888BB40
    }

    public class UserAndRoomList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC888BE50
    }

    public class UserCapability : Object
    {
        public string Description; // 0x10
        public bool IsEnabled; // 0x18
        public string Name; // 0x20
        public string ReasonCode; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC888C240
    }

    public class UserCapabilityList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC888C5E0
    }

    public class UserDataStoreUpdateResponse : Object
    {
        public bool Success; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC888C9D0
    }

    public class UserList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC888B750
    }

    public class UserProof : Object
    {
        public string Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC888CAA0
    }

    public class UserReportID : Object
    {
        public bool DidCancel; // 0x10
        public ulong ID; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC888CBF0
    }

}