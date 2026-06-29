// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 11
// Methods: 15

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class Party : Object
    {
        public object ID;
        public object InvitedUsersOptional;
        public object InvitedUsers;
        public object LeaderOptional;
        public object Leader;
        public object RoomOptional;
        public object Room;
        public object UsersOptional;
        public object Users;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B61B40
    }

    public class PartyID : Object
    {
        public object ID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B62290
    }

    public class PartyUpdateNotification : Object
    {
        public object Action;
        public object PartyId;
        public object SenderId;
        public object UpdateTimestamp;
        public object UserAlias;
        public object UserId;
        public object UserName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B62350
    }

    public class Pid : Object
    {
        public object Id;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B62810
    }

    public class PidList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B62960
    }

    public class PingResult : Object
    {
        public object _iD;
        public object pingTimeUsec;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B62D50
        public void get_ID(){} // RVA: 0xB5DBF0
        public void set_ID(){} // RVA: 0x2230E30
        public void get_PingTimeUsec(){} // RVA: 0x6B62D60
        public void get_IsTimeout(){} // RVA: 0x6B62DC0
    }

    public class PlatformInitialize : Object
    {
        public object Result;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B62E00
    }

    public class Product : Object
    {
        public object Description;
        public object FormattedPrice;
        public object Name;
        public object Sku;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B62EC0
    }

    public class ProductList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B63300
    }

    public class Purchase : Object
    {
        public object DeveloperPayload;
        public object ExpirationTime;
        public object GrantTime;
        public object ID;
        public object ReportingId;
        public object Sku;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B636E0
    }

    public class PurchaseList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B63C50
    }

}