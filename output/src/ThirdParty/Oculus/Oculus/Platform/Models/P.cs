// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 11
// Methods: 15

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class Party : Object
    {
        public ulong ID; // 0x10
        public Oculus.Platform.Models.UserList InvitedUsersOptional; // 0x18
        public Oculus.Platform.Models.UserList InvitedUsers; // 0x20
        public Oculus.Platform.Models.User LeaderOptional; // 0x28
        public Oculus.Platform.Models.User Leader; // 0x30
        public Oculus.Platform.Models.Room RoomOptional; // 0x38
        public Oculus.Platform.Models.Room Room; // 0x40
        public Oculus.Platform.Models.UserList UsersOptional; // 0x48
        public Oculus.Platform.Models.UserList Users; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8885FC0
    }

    public class PartyID : Object
    {
        public ulong ID; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8886710
    }

    public class PartyUpdateNotification : Object
    {
        public 0x6B257890 Action; // 0x10
        public ulong PartyId; // 0x18
        public ulong SenderId; // 0x20
        public string UpdateTimestamp; // 0x28
        public string UserAlias; // 0x30
        public ulong UserId; // 0x38
        public string UserName; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88867D0
    }

    public class Pid : Object
    {
        public string Id; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8886C70
    }

    public class PidList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8886DC0
    }

    public class PingResult : Object
    {
        public ulong ID; // 0x10
        public System.Nullable`1<ulong> PingTimeUsec; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88871C0
        public void get_ID(){} // RVA: 0x7FFAC2F3C380
        public void set_ID(){} // RVA: 0x7FFAC441EFB0
        public void get_PingTimeUsec(){} // RVA: 0x7FFAC88871D0
        public void get_IsTimeout(){} // RVA: 0x7FFAC8887230
    }

    public class PlatformInitialize : Object
    {
        public 0x6B258440 Result; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8887270
    }

    public class Product : Object
    {
        public string Description; // 0x10
        public string FormattedPrice; // 0x18
        public string Name; // 0x20
        public string Sku; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8887330
    }

    public class ProductList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8887760
    }

    public class Purchase : Object
    {
        public string DeveloperPayload; // 0x10
        public System.DateTime ExpirationTime; // 0x18
        public System.DateTime GrantTime; // 0x20
        public string ID; // 0x28
        public string ReportingId; // 0x30
        public string Sku; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8887B50
    }

    public class PurchaseList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88880B0
    }

}