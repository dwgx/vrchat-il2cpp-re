// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Transmtn
// Classes: 26
// Methods: 130

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
        public void .ctor(){} // RVA: 0x7FFD574E4F90
        public void Dispose(){} // RVA: 0x7FFD574E5E90
    }

    public class ChallengesWebsocketEventHandler : Object
    {
        public System.EventHandler`1<VRC.DataModel.Challenges.ChallengeEvent> OnUpdateReceived; // 0x10

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFD574E5F60
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFD574E6060
        public void In(){} // RVA: 0x7FFD574E6160
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ContentEvent : EventArgs
    {
        public string ContentType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574E7CC0
    }

    public class ContentWebSocketEventHandler : Object
    {
        public System.EventHandler`1<Transmtn.ContentEvent> OnUpdateReceived; // 0x10

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFD574E6A00
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFD574E6B00
        public void In(){} // RVA: 0x7FFD574E6C00
        public void .ctor(){} // RVA: 0x7FFD4E341310
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
        public void .ctor(){} // RVA: 0x7FFD574E9330
    }

    public class EconomyWebsocketEventHandler : Object
    {
        public System.EventHandler`1<Transmtn.EconomyEvent> OnUpdateReceived; // 0x10

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFD574E7D10
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFD574E7E10
        public void In(){} // RVA: 0x7FFD574E7F10
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class GroupEvent : EventArgs
    {
        public string groupId; // 0x10
        public ÏÏÍÍÏÍÌÍÍÌÌÌÌÎÎÌÎÌÍ.ÍÏÎÍÏÍÍÌÌÍÍÍÏÎÌÍÍÌÌÍÌÍÌ eventType; // 0x18
        public string data; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574EA850
    }

    public class GroupsWebSocketEventHandler : Object
    {
        public System.EventHandler`1<Transmtn.GroupEvent> OnUpdateReceived; // 0x10

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFD574E9380
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFD574E9480
        public void In(){} // RVA: 0x7FFD574E9580
        public void Handle(){} // RVA: 0x7FFD574E9730
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class HttpClient : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFD574EA8A0
        public void Post(){} // RVA: 0x7FFD574EA940
        public void Put(){} // RVA: 0x7FFD574EABD0
        public void Delete(){} // RVA: 0x7FFD574EAC60
        public void MakeResponseContainer(){} // RVA: 0x7FFD574EACF0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class IAcceptMessages
    {
        // ── Methods ──
        public void In(){}
    }

    public class IEventHandler`1
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFD4E090A40
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFD4E090A40
    }

    public class IServerTimeProvider
    {
        public object ServerTimeUtc;

        // ── Methods ──
        public void get_ServerTimeUtc(){} // RVA: 0x7FFD4E078E90
    }

    public class InstanceEvent : EventArgs
    {
        public string EventType; // 0x10
        public string InstanceLocation; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574EBFE0
    }

    public class InstanceWebSocketEventHandler : Object
    {
        public System.EventHandler`1<Transmtn.InstanceEvent> OnUpdateReceived; // 0x10

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFD574EB290
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFD574EB390
        public void In(){} // RVA: 0x7FFD574EB490
        public void Handle(){} // RVA: 0x7FFD574EB650
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class InventoryEvent : Object
    {
        public 0x6660BCC0 Type; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD4E38E5C0
        public void set_Type(){} // RVA: 0x7FFD4E3440C0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class InventoryWebSocketEventHandler : Object
    {
        public System.EventHandler`1<Transmtn.InventoryEvent> OnUpdateReceived; // 0x10

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFD574EC030
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFD574EC130
        public void In(){} // RVA: 0x7FFD574EC230
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class PhoneBook : Object
    {
        public System.EventHandler`1<Transmtn.UpdateEvent> OnUpdateReceived; // 0x10

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFD574ECF40
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFD574ED040
        public void In(){} // RVA: 0x7FFD574ED140
        public void Handle(){} // RVA: 0x7FFD574ED2F0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class PostOffice : Object
    {
        public Transmtn.HttpClient HttpClient; // 0x10
        public string Messages; // 0x18
        public string FriendRequests; // 0x20
        public System.EventHandler`1<0x6660BFD8> Invites; // 0x28
        public int Broadcasts;
        public Transmtn.IServerTimeProvider Alerts; // 0x30
        public System.TimeSpan TopFourNotifications;
        public System.Collections.Generic.SortedList`2<System.DateTime,Transmtn.DTO.Notifications.Notification> RecentNotifications; // 0x38
        public System.Collections.Generic.Dictionary`2<string,Transmtn.DTO.Notifications.Notification> Notifications; // 0x40
        public System.Collections.Generic.List`1<string> SortedNotifications; // 0x48
        public System.Collections.Generic.List`1<string> NotificationDictionary; // 0x50
        public int NotificationsToDelete;

        // ── Methods ──
        public void get_HttpClient(){} // RVA: 0x7FFD4E35C380
        public void set_HttpClient(){} // RVA: 0x7FFD4E342E30
        public void add_OnNotification(){} // RVA: 0x7FFD574F0170
        public void remove_OnNotification(){} // RVA: 0x7FFD574F0270
        public void get_Messages(){} // RVA: 0x7FFD574F0370
        public void get_FriendRequests(){} // RVA: 0x7FFD574F04F0
        public void get_Invites(){} // RVA: 0x7FFD574F0670
        public void get_Broadcasts(){} // RVA: 0x7FFD574F07F0
        public void get_Alerts(){} // RVA: 0x7FFD574F0970
        public void get_TopFourNotifications(){} // RVA: 0x7FFD574F0AF0
        public void get_RecentNotifications(){} // RVA: 0x7FFD574F0B40
        public void get_Notifications(){} // RVA: 0x7FFD574F0BF0
        public void get_SortedNotifications(){} // RVA: 0x7FFD4E5F0140
        public void set_SortedNotifications(){} // RVA: 0x7FFD4E5F0C20
        public void get_NotificationDictionary(){} // RVA: 0x7FFD4E3BE740
        public void set_NotificationDictionary(){} // RVA: 0x7FFD4E369200
        public void get_NotificationsToDelete(){} // RVA: 0x7FFD4E3BC730
        public void set_NotificationsToDelete(){} // RVA: 0x7FFD4E3BC740
        public void get_NotificationsToUpdate(){} // RVA: 0x7FFD4E3E20E0
        public void set_NotificationsToUpdate(){} // RVA: 0x7FFD4E4994D0
        public void ContainsValidImageDataAttachment(){} // RVA: 0x7FFD574F0C70
        public void .ctor(){} // RVA: 0x7FFD574F0C90
        public void In(){} // RVA: 0x7FFD574F10C0
        public void ProcessNotification(){} // RVA: 0x7FFD574F1290
        public void Remove(){} // RVA: 0x7FFD574F1820 | overloaded x2
        public void See(){} // RVA: 0x7FFD574F1D70 | overloaded x2
        public void FetchFriendRequests(){} // RVA: 0x7FFD574F1DE0
        public void FetchNotifications(){} // RVA: 0x7FFD574F1FC0
        public void Send(){} // RVA: 0x7FFD574F21C0
        public void MarkAsSeen(){} // RVA: 0x7FFD574F2F20
        public void Delete(){} // RVA: 0x7FFD574F31F0
        public void Hide(){} // RVA: 0x7FFD574F3640
        public void AnswerNotification(){} // RVA: 0x7FFD574F3940
        public void ReplyNotification(){} // RVA: 0x7FFD574F3CC0
        public void AcceptFriendRequest(){} // RVA: 0x7FFD574F3E80
        public void .cctor(){} // RVA: 0x7FFD574F42B0
        public void <get_RecentNotifications>b__25_0(){} // RVA: 0x7FFD574F4340
        public void <FetchNotifications>b__54_0(){} // RVA: 0x7FFD574F4450
    }

    public class QueueEvent : EventArgs
    {
        public string EventType; // 0x10
        public string InstanceLocation; // 0x18
        public System.DateTime Expiry; // 0x20
        public int Position; // 0x28
        public int QueueSize; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574F9190
    }

    public class QueueWebSocketEventHandler : Object
    {
        public System.EventHandler`1<Transmtn.QueueEvent> OnUpdateReceived; // 0x10

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFD574F7D70
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFD574F7E70
        public void In(){} // RVA: 0x7FFD574F7F70
        public void HandleReady(){} // RVA: 0x7FFD574F8130
        public void Handle(){} // RVA: 0x7FFD574F82C0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Router : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,Transmtn.IAcceptMessages> _routes; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574FA320
        public void AddRoute(){} // RVA: 0x7FFD574FA3E0
        public void ProcessItem(){} // RVA: 0x7FFD574FA520
    }

    public class SocketEnvelope : Object
    {
        public string type; // 0x10
        public string content; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574FAD20
        public void get_type(){} // RVA: 0x7FFD4E35C380
        public void set_type(){} // RVA: 0x7FFD4E342E30
        public void get_content(){} // RVA: 0x7FFD4E3447C0
        public void set_content(){} // RVA: 0x7FFD4E3A7E80
    }

    public class TextureEvent : Object
    {
        public 0x6660C500 Type; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD4E38E5C0
        public void set_Type(){} // RVA: 0x7FFD4E3440C0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TextureWebSocketEventHandler : Object
    {
        public System.EventHandler`1<Transmtn.TextureEvent> OnUpdateReceived; // 0x10

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFD574F91E0
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFD574F92E0
        public void In(){} // RVA: 0x7FFD574F93E0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class UpdateEvent : EventArgs
    {
        public Transmtn.DTO.User user; // 0x10
        public ÌÎÌÌÍÏÏÌÍÍ messageType; // 0x18

        // ── Methods ──
        public void get_user(){} // RVA: 0x7FFD4E35C380
        public void set_user(){} // RVA: 0x7FFD4E342E30
        public void get_messageType(){} // RVA: 0x7FFD4E577800
        public void set_messageType(){} // RVA: 0x7FFD4ED4CD10
        public void .ctor(){} // RVA: 0x7FFD574ECE80
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
        public void add_OnConnectionEstablished(){} // RVA: 0x7FFD574FAE80
        public void remove_OnConnectionEstablished(){} // RVA: 0x7FFD574FAF70
        public void add_OnLostConnection(){} // RVA: 0x7FFD574FB060
        public void remove_OnLostConnection(){} // RVA: 0x7FFD574FB160
        public void LogError(){} // RVA: 0x7FFD574FB260
        public void LogDebug(){} // RVA: 0x7FFD574FB410
        public void .ctor(){} // RVA: 0x7FFD574FB5C0
        public void ProcessPipe(){} // RVA: 0x7FFD574FB990
        public void Dispose(){} // RVA: 0x7FFD574FBAD0
        public void <ProcessPipe>b__17_0(){} // RVA: 0x7FFD574FBBA0
        public void <ProcessPipe>b__17_1(){} // RVA: 0x7FFD4E623950
        public void <ProcessPipe>b__17_2(){} // RVA: 0x7FFD574FBCC0
        public void <ProcessPipe>b__17_3(){} // RVA: 0x7FFD574FBDD0
    }

}