// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 9
// Methods: 9

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class User : Object
    {
        public object DisplayName;
        public object ID;
        public object ImageURL;
        public object InviteToken;
        public object OculusID;
        public object Presence;
        public object PresenceDeeplinkMessage;
        public object PresenceDestinationApiName;
        public object PresenceLobbySessionId;
        public object PresenceMatchSessionId;
        public object PresenceStatus;
        public object SmallImageUrl;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B66840
    }

    public class UserAndRoom : Object
    {
        public object RoomOptional;
        public object Room;
        public object User;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B676A0
    }

    public class UserAndRoomList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B679B0
    }

    public class UserCapability : Object
    {
        public object Description;
        public object IsEnabled;
        public object Name;
        public object ReasonCode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B67D90
    }

    public class UserCapabilityList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B68140
    }

    public class UserDataStoreUpdateResponse : Object
    {
        public object Success;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B68520
    }

    public class UserList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B672C0
    }

    public class UserProof : Object
    {
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B685F0
    }

    public class UserReportID : Object
    {
        public object DidCancel;
        public object ID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B68740
    }

}