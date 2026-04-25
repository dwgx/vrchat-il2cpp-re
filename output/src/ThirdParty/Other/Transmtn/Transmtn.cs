// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Transmtn
// Classes: 33
// Methods: 153

namespace ThirdParty.Other.Transmtn
{
    public class Api : Object
    {
        public Transmtn.WebsocketPipeline _websocketPipeline; // 0x10
        public Transmtn.PhoneBook PhoneBook; // 0x18
        public Transmtn.PostOffice PostOffice; // 0x20
        public Transmtn.GroupsWebSocketEventHandler GroupsWebSocketEventHandler; // 0x28
        public Transmtn.QueueWebSocketEventHandler QueueWebSocketEventHandler; // 0x30
        public Transmtn.ContentWebSocketEventHandler ContentWebSocketEventHandler; // 0x38
        public Transmtn.EconomyWebsocketEventHandler EconomyWebSocketEventHandler; // 0x40
        public Transmtn.InstanceWebSocketEventHandler InstanceWebSocketEventHandler; // 0x48
        public Transmtn.ChallengesWebsocketEventHandler ChallengesWebsocketEventHandler; // 0x50
        public Transmtn.InventoryWebSocketEventHandler InventoryWebSocketEventHandler; // 0x58
        public Transmtn.TextureWebSocketEventHandler TextureWebSocketEventHandler; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0C4F90
        public void Dispose(){} // RVA: 0x7FFACC0C5E90
    }

    public class ChallengesWebsocketEventHandler : Object
    {
        public System.EventHandler`1<VRC.DataModel.Challenges.ChallengeEvent> OnUpdateReceived; // 0x10

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFACC0C5F60
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFACC0C6060
        public void In(){} // RVA: 0x7FFACC0C6160
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ContentEvent : EventArgs
    {
        public string ContentType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0C7CC0
    }

    public class ContentWebSocketEventHandler : Object
    {
        public System.EventHandler`1<Transmtn.ContentEvent> OnUpdateReceived; // 0x10

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFACC0C6A00
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFACC0C6B00
        public void In(){} // RVA: 0x7FFACC0C6C00
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EconomyEvent : EventArgs
    {
        public bool UpdateWallet; // 0x10
        public int WalletBalance; // 0x14
        public string DirtyPurchases; // 0x18
        public System.Collections.Generic.Dictionary`2<string,object> PurchaseToken; // 0x20
        public string IsGift; // 0x28
        public string GiftBuyerId; // 0x30
        public string GiftListingId; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0C9330
    }

    public class EconomyWebsocketEventHandler : Object
    {
        public System.EventHandler`1<Transmtn.EconomyEvent> OnUpdateReceived; // 0x10

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFACC0C7D10
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFACC0C7E10
        public void In(){} // RVA: 0x7FFACC0C7F10
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class GroupEvent : EventArgs
    {
        public string groupId; // 0x10
        public 0x6B2AB9A8 eventType; // 0x18
        public string data; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0CA850
    }

    public class GroupsWebSocketEventHandler : Object
    {
        public System.EventHandler`1<Transmtn.GroupEvent> OnUpdateReceived; // 0x10

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFACC0C9380
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFACC0C9480
        public void In(){} // RVA: 0x7FFACC0C9580
        public void Handle(){} // RVA: 0x7FFACC0C9730
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class HttpClient : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFACC0CA8A0
        public void Post(){} // RVA: 0x7FFACC0CA940
        public void Put(){} // RVA: 0x7FFACC0CABD0
        public void Delete(){} // RVA: 0x7FFACC0CAC60
        public void MakeResponseContainer(){} // RVA: 0x7FFACC0CACF0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IAcceptMessages
    {
        // ── Methods ──
        public void In(){}
    }

    public class IEventHandler`1
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFAC2C70A40
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFAC2C70A40
    }

    public class IServerTimeProvider
    {
        public object ServerTimeUtc;

        // ── Methods ──
        public void get_ServerTimeUtc(){} // RVA: 0x7FFAC2C58E90
    }

    public class InstanceEvent : EventArgs
    {
        public string EventType; // 0x10
        public string InstanceLocation; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0CBFE0
    }

    public class InstanceWebSocketEventHandler : Object
    {
        public System.EventHandler`1<Transmtn.InstanceEvent> OnUpdateReceived; // 0x10

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFACC0CB290
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFACC0CB390
        public void In(){} // RVA: 0x7FFACC0CB490
        public void Handle(){} // RVA: 0x7FFACC0CB650
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class InventoryContentEvent : ContentEvent
    {
        public string ItemId; // 0x18
        public string ItemType; // 0x20
        public string ActionType; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0C7CC0
    }

    public class InventoryEvent : Object
    {
        public 0x6B2ABCC0 Type; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2F6E5C0
        public void set_Type(){} // RVA: 0x7FFAC2F240C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class InventoryShareEvent : InventoryEvent
    {
        public string FromUserId; // 0x18
        public string ItemId; // 0x20
        public string FromDisplayName; // 0x28
        public string Token; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
        public void get_FromUserId(){} // RVA: 0x7FFAC2F247C0
        public void set_FromUserId(){} // RVA: 0x7FFAC2F87E80
        public void get_ItemId(){} // RVA: 0x7FFAC2F4F0C0
        public void set_ItemId(){} // RVA: 0x7FFAC2F4F0D0
        public void get_FromDisplayName(){} // RVA: 0x7FFAC2F4F130
        public void set_FromDisplayName(){} // RVA: 0x7FFAC2F22E90
        public void get_Token(){} // RVA: 0x7FFAC31D95E0
        public void set_Token(){} // RVA: 0x7FFAC2F4F890
    }

    public class InventoryWebSocketEventHandler : Object
    {
        public System.EventHandler`1<Transmtn.InventoryEvent> OnUpdateReceived; // 0x10

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFACC0CC030
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFACC0CC130
        public void In(){} // RVA: 0x7FFACC0CC230
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class LegacyContentEvent : ContentEvent
    {
        public string FileID; // 0x18
        public string ActionType; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0C7CC0
    }

    public class ModifiedImageUpdateEvent : TextureEvent
    {
        public string FileID; // 0x18
        public string VersionNumber; // 0x20
        public int PixelSize; // 0x28
        public bool NeedsProcessing; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
        public void get_FileID(){} // RVA: 0x7FFAC2F247C0
        public void set_FileID(){} // RVA: 0x7FFAC2F87E80
        public void get_VersionNumber(){} // RVA: 0x7FFAC2F4F0C0
        public void set_VersionNumber(){} // RVA: 0x7FFAC2F4F0D0
        public void get_PixelSize(){} // RVA: 0x7FFAC32EC4C0
        public void set_PixelSize(){} // RVA: 0x7FFAC369A6E0
        public void get_NeedsProcessing(){} // RVA: 0x7FFAC3000230
        public void set_NeedsProcessing(){} // RVA: 0x7FFAC3000240
    }

    public class NotificationDeleteEvent : ValueType
    {
        public string[] ids; // 0x10
        public int version; // 0x18
    }

    public class NotificationEvent : EventArgs
    {
        public Transmtn.DTO.Notifications.Notification notification; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0D00D0
        public void get_notification(){} // RVA: 0x7FFAC2F3C380
        public void set_notification(){} // RVA: 0x7FFAC2F22E30
    }

    public class NotificationUpdateEvent : ValueType
    {
        public string id; // 0x10
        public int version; // 0x18
        public System.Collections.Generic.Dictionary`2<string,object> updates; // 0x20
    }

    public class PhoneBook : Object
    {
        public System.EventHandler`1<Transmtn.UpdateEvent> OnUpdateReceived; // 0x10

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFACC0CCF40
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFACC0CD040
        public void In(){} // RVA: 0x7FFACC0CD140
        public void Handle(){} // RVA: 0x7FFACC0CD2F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PostOffice : Object
    {
        public Transmtn.HttpClient HttpClient; // 0x10
        public string Messages; // 0x18
        public string FriendRequests; // 0x20
        public System.EventHandler`1<Transmtn.NotificationEvent> Invites; // 0x28
        public int Broadcasts;
        public Transmtn.IServerTimeProvider Alerts; // 0x30
        public System.TimeSpan TopFourNotifications;
        public System.Collections.Generic.SortedList`2<System.DateTime,Transmtn.DTO.Notifications.Notification> RecentNotifications; // 0x38
        public System.Collections.Generic.Dictionary`2<string,Transmtn.DTO.Notifications.Notification> Notifications; // 0x40
        public System.Collections.Generic.List`1<string> SortedNotifications; // 0x48
        public System.Collections.Generic.List`1<string> NotificationDictionary; // 0x50
        public int NotificationsToDelete;

        // ── Methods ──
        public void get_HttpClient(){} // RVA: 0x7FFAC2F3C380
        public void set_HttpClient(){} // RVA: 0x7FFAC2F22E30
        public void add_OnNotification(){} // RVA: 0x7FFACC0D0170
        public void remove_OnNotification(){} // RVA: 0x7FFACC0D0270
        public void get_Messages(){} // RVA: 0x7FFACC0D0370
        public void get_FriendRequests(){} // RVA: 0x7FFACC0D04F0
        public void get_Invites(){} // RVA: 0x7FFACC0D0670
        public void get_Broadcasts(){} // RVA: 0x7FFACC0D07F0
        public void get_Alerts(){} // RVA: 0x7FFACC0D0970
        public void get_TopFourNotifications(){} // RVA: 0x7FFACC0D0AF0
        public void get_RecentNotifications(){} // RVA: 0x7FFACC0D0B40
        public void get_Notifications(){} // RVA: 0x7FFACC0D0BF0
        public void get_SortedNotifications(){} // RVA: 0x7FFAC31D0140
        public void set_SortedNotifications(){} // RVA: 0x7FFAC31D0C20
        public void get_NotificationDictionary(){} // RVA: 0x7FFAC2F9E740
        public void set_NotificationDictionary(){} // RVA: 0x7FFAC2F49200
        public void get_NotificationsToDelete(){} // RVA: 0x7FFAC2F9C730
        public void set_NotificationsToDelete(){} // RVA: 0x7FFAC2F9C740
        public void get_NotificationsToUpdate(){} // RVA: 0x7FFAC2FC20E0
        public void set_NotificationsToUpdate(){} // RVA: 0x7FFAC30794D0
        public void ContainsValidImageDataAttachment(){} // RVA: 0x7FFACC0D0C70
        public void .ctor(){} // RVA: 0x7FFACC0D0C90
        public void In(){} // RVA: 0x7FFACC0D10C0
        public void ProcessNotification(){} // RVA: 0x7FFACC0D1290
        public void Remove(){} // RVA: 0x7FFACC0D1820 | overloaded x2
        public void See(){} // RVA: 0x7FFACC0D1D70 | overloaded x2
        public void FetchFriendRequests(){} // RVA: 0x7FFACC0D1DE0
        public void FetchNotifications(){} // RVA: 0x7FFACC0D1FC0
        public void Send(){} // RVA: 0x7FFACC0D21C0
        public void MarkAsSeen(){} // RVA: 0x7FFACC0D2F20
        public void Delete(){} // RVA: 0x7FFACC0D31F0
        public void Hide(){} // RVA: 0x7FFACC0D3640
        public void AnswerNotification(){} // RVA: 0x7FFACC0D3940
        public void ReplyNotification(){} // RVA: 0x7FFACC0D3CC0
        public void AcceptFriendRequest(){} // RVA: 0x7FFACC0D3E80
        public void .cctor(){} // RVA: 0x7FFACC0D42B0
        public void <get_RecentNotifications>b__25_0(){} // RVA: 0x7FFACC0D4340
        public void <FetchNotifications>b__54_0(){} // RVA: 0x7FFACC0D4450
    }

    public class QueueEvent : EventArgs
    {
        public string EventType; // 0x10
        public string InstanceLocation; // 0x18
        public System.DateTime Expiry; // 0x20
        public int Position; // 0x28
        public int QueueSize; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0D9190
    }

    public class QueueWebSocketEventHandler : Object
    {
        public System.EventHandler`1<Transmtn.QueueEvent> OnUpdateReceived; // 0x10

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFACC0D7D70
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFACC0D7E70
        public void In(){} // RVA: 0x7FFACC0D7F70
        public void HandleReady(){} // RVA: 0x7FFACC0D8130
        public void Handle(){} // RVA: 0x7FFACC0D82C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Router : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,Transmtn.IAcceptMessages> _routes; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0DA320
        public void AddRoute(){} // RVA: 0x7FFACC0DA3E0
        public void ProcessItem(){} // RVA: 0x7FFACC0DA520
    }

    public class SocketEnvelope : Object
    {
        public string type; // 0x10
        public string content; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0DAD20
        public void get_type(){} // RVA: 0x7FFAC2F3C380
        public void set_type(){} // RVA: 0x7FFAC2F22E30
        public void get_content(){} // RVA: 0x7FFAC2F247C0
        public void set_content(){} // RVA: 0x7FFAC2F87E80
    }

    public class TextureEvent : Object
    {
        public 0x6B2AC500 Type; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2F6E5C0
        public void set_Type(){} // RVA: 0x7FFAC2F240C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TextureWebSocketEventHandler : Object
    {
        public System.EventHandler`1<Transmtn.TextureEvent> OnUpdateReceived; // 0x10

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFACC0D91E0
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFACC0D92E0
        public void In(){} // RVA: 0x7FFACC0D93E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UpdateEvent : EventArgs
    {
        public Transmtn.DTO.User user; // 0x10
        public 0x6B2AB270 messageType; // 0x18

        // ── Methods ──
        public void get_user(){} // RVA: 0x7FFAC2F3C380
        public void set_user(){} // RVA: 0x7FFAC2F22E30
        public void get_messageType(){} // RVA: 0x7FFAC3157800
        public void set_messageType(){} // RVA: 0x7FFAC392CD10
        public void .ctor(){} // RVA: 0x7FFACC0CCE80
    }

    public class WebsocketPipeline : Object
    {
        public System.Action OnConnectionEstablished; // 0x10
        public System.Action`1<string> OnLostConnection; // 0x18
        public Transmtn.Router _router; // 0x20
        public string _endpoint; // 0x28
        public string _authToken; // 0x30
        public string _macAddress; // 0x38
        public string _clientVersion; // 0x40
        public string _platform; // 0x48
        public System.Guid _connectionId; // 0x50
        public System.Threading.CancellationTokenSource _pipeCancellationSource; // 0x60

        // ── Methods ──
        public void add_OnConnectionEstablished(){} // RVA: 0x7FFACC0DAE80
        public void remove_OnConnectionEstablished(){} // RVA: 0x7FFACC0DAF70
        public void add_OnLostConnection(){} // RVA: 0x7FFACC0DB060
        public void remove_OnLostConnection(){} // RVA: 0x7FFACC0DB160
        public void LogError(){} // RVA: 0x7FFACC0DB260
        public void LogDebug(){} // RVA: 0x7FFACC0DB410
        public void .ctor(){} // RVA: 0x7FFACC0DB5C0
        public void ProcessPipe(){} // RVA: 0x7FFACC0DB990
        public void Dispose(){} // RVA: 0x7FFACC0DBAD0
        public void <ProcessPipe>b__17_0(){} // RVA: 0x7FFACC0DBBA0
        public void <ProcessPipe>b__17_1(){} // RVA: 0x7FFAC3203950
        public void <ProcessPipe>b__17_2(){} // RVA: 0x7FFACC0DBCC0
        public void <ProcessPipe>b__17_3(){} // RVA: 0x7FFACC0DBDD0
    }

}