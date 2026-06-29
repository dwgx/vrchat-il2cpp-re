// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Transmtn
// Classes: 36
// Methods: 151

namespace ThirdParty.Other.Transmtn
{
    public class Api : Object
    {
        public object _websocketPipeline;
        public object PhoneBook;
        public object PostOffice;
        public object GroupsWebSocketEventHandler;
        public object QueueWebSocketEventHandler;
        public object ContentWebSocketEventHandler;
        public object EconomyWebSocketEventHandler;
        public object InstanceWebSocketEventHandler;
        public object ChallengesWebsocketEventHandler;
        public object InventoryWebSocketEventHandler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA79AE60
        public void Dispose(){} // RVA: 0xA79BCD0
    }

    public class ChallengesWebsocketEventHandler : Object
    {
        public object OnUpdateReceived;

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0xA79BDA0
        public void remove_OnUpdateReceived(){} // RVA: 0xA79BEB0
        public void In(){} // RVA: 0xA79BFC0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ContentEvent : EventArgs
    {
        public object ContentType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA79DB40
    }

    public class ContentWebSocketEventHandler : Object
    {
        public object OnUpdateReceived;

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0xA79C860
        public void remove_OnUpdateReceived(){} // RVA: 0xA79C970
        public void In(){} // RVA: 0xA79CA80
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EconomyEvent : EventArgs
    {
        public object UpdateWallet;
        public object WalletBalance;
        public object DirtyPurchases;
        public object PurchaseToken;
        public object IsGift;
        public object GiftBuyerId;
        public object GiftListingId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA79F1C0
    }

    public class EconomyWebsocketEventHandler : Object
    {
        public object OnUpdateReceived;

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0xA79DB90
        public void remove_OnUpdateReceived(){} // RVA: 0xA79DCA0
        public void In(){} // RVA: 0xA79DDB0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class GroupEvent : EventArgs
    {
        public object groupId;
        public object eventType;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7A0700
    }

    public class GroupsWebSocketEventHandler : Object
    {
        public object OnUpdateReceived;

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0xA79F210
        public void remove_OnUpdateReceived(){} // RVA: 0xA79F320
        public void In(){} // RVA: 0xA79F430
        public void Handle(){} // RVA: 0xA79F5E0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class HttpClient : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0xA7A0750
        public void Post(){} // RVA: 0xA7A07F0
        public void Put(){} // RVA: 0xA7A0A80
        public void Delete(){} // RVA: 0xA7A0B10
        public void MakeResponseContainer(){} // RVA: 0xA7A0BA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class IAcceptMessages
    {
        // ── Methods ──
        public void In(){} // RVA: 0x87BF80
    }

    public class IEventHandler`1
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x894320
        public void remove_OnUpdateReceived(){} // RVA: 0x894320
    }

    public class IEventHandler`1
    {
        // ── Methods ──
        public void remove_OnUpdateReceived(){} // RVA: 0x894320
        public void add_OnUpdateReceived(){} // RVA: 0x894320
    }

    public class IEventHandler`1
    {
        // ── Methods ──
        public void remove_OnUpdateReceived(){} // RVA: 0x894320
        public void add_OnUpdateReceived(){} // RVA: 0x894320
    }

    public class IEventHandler`1
    {
        // ── Methods ──
        public void remove_OnUpdateReceived(){} // RVA: 0x894320
        public void add_OnUpdateReceived(){} // RVA: 0x894320
    }

    public class IEventHandler`1
    {
        // ── Methods ──
        public void remove_OnUpdateReceived(){} // RVA: 0x894320
        public void add_OnUpdateReceived(){} // RVA: 0x894320
    }

    public class IEventHandler`1
    {
        // ── Methods ──
        public void remove_OnUpdateReceived(){} // RVA: 0x894320
        public void add_OnUpdateReceived(){} // RVA: 0x894320
    }

    public class IEventHandler`1
    {
        // ── Methods ──
        public void remove_OnUpdateReceived(){} // RVA: 0x894320
        public void add_OnUpdateReceived(){} // RVA: 0x894320
    }

    public class IEventHandler`1
    {
        // ── Methods ──
        public void remove_OnUpdateReceived(){} // RVA: 0x894320
        public void add_OnUpdateReceived(){} // RVA: 0x894320
    }

    public class IEventHandler`1
    {
        // ── Methods ──
        public void remove_OnUpdateReceived(){} // RVA: 0x894320
        public void add_OnUpdateReceived(){} // RVA: 0x894320
    }

    public class IServerTimeProvider
    {
        // ── Methods ──
        public void get_ServerTimeUtc(){} // RVA: 0x87C0A0
    }

    public class InstanceEvent : EventArgs
    {
        public object EventType;
        public object InstanceLocation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7A1E00
    }

    public class InstanceWebSocketEventHandler : Object
    {
        public object OnUpdateReceived;

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0xA7A1080
        public void remove_OnUpdateReceived(){} // RVA: 0xA7A1190
        public void In(){} // RVA: 0xA7A12A0
        public void Handle(){} // RVA: 0xA7A1460
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InventoryContentEvent : ContentEvent
    {
        public object ItemId;
        public object ItemType;
        public object ActionType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA79DB40
    }

    public class InventoryEvent : Object
    {
        public object _type;

        // ── Methods ──
        public void get_Type(){} // RVA: 0xB8F8F0
        public void set_Type(){} // RVA: 0xB460A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InventoryShareEvent : InventoryEvent
    {
        public object _fromUserId;
        public object _itemId;
        public object _fromDisplayName;
        public object _token;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x132A2D0
        public void get_FromUserId(){} // RVA: 0xB465B0
        public void set_FromUserId(){} // RVA: 0xBA9BA0
        public void get_ItemId(){} // RVA: 0xB700F0
        public void set_ItemId(){} // RVA: 0xB70100
        public void get_FromDisplayName(){} // RVA: 0xB70160
        public void set_FromDisplayName(){} // RVA: 0xB44DC0
        public void get_Token(){} // RVA: 0xD33E60
        public void set_Token(){} // RVA: 0xB708C0
    }

    public class InventoryWebSocketEventHandler : Object
    {
        public object OnUpdateReceived;

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0xA7A1E50
        public void remove_OnUpdateReceived(){} // RVA: 0xA7A1F60
        public void In(){} // RVA: 0xA7A2070
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LegacyContentEvent : ContentEvent
    {
        public object FileID;
        public object ActionType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA79DB40
    }

    public class NotificationEvent : EventArgs
    {
        public object _notification;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7A5EF0
        public void get_notification(){} // RVA: 0xB5DBF0
        public void set_notification(){} // RVA: 0xB44D60
    }

    public class PhoneBook : Object
    {
        public object OnUpdateReceived;

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0xA7A2D90
        public void remove_OnUpdateReceived(){} // RVA: 0xA7A2EA0
        public void In(){} // RVA: 0xA7A2FB0
        public void Handle(){} // RVA: 0xA7A3160
        public void .ctor(){} // RVA: 0xB43310
    }

    public class PostOffice : Object
    {
        public object _httpClient;
        public object NOTIFICATION;
        public object NOTIFICATIONV2;
        public object OnNotification;
        public object maximumAllowedFileAttachmentInBytes;
        public object _serverTimeProvider;
        public object fiveMinutes;
        public object _sortedNotifications;
        public object _notificationDictionary;
        public object _notificationsToDelete;
        public object _notificationsToUpdate;
        public object fetchCount;

        // ── Methods ──
        public void get_HttpClient(){} // RVA: 0xB5DBF0
        public void set_HttpClient(){} // RVA: 0xB44D60
        public void add_OnNotification(){} // RVA: 0xA7A5F90
        public void remove_OnNotification(){} // RVA: 0xA7A60A0
        public void get_Messages(){} // RVA: 0xA7A61B0
        public void get_FriendRequests(){} // RVA: 0xA7A6330
        public void get_Invites(){} // RVA: 0xA7A64B0
        public void get_Broadcasts(){} // RVA: 0xA7A6630
        public void get_Alerts(){} // RVA: 0xA7A67B0
        public void get_TopFourNotifications(){} // RVA: 0xA7A6930
        public void get_RecentNotifications(){} // RVA: 0xA7A6980
        public void get_Notifications(){} // RVA: 0xA7A6A30
        public void get_SortedNotifications(){} // RVA: 0xD05CA0
        public void set_SortedNotifications(){} // RVA: 0xD09D70
        public void get_NotificationDictionary(){} // RVA: 0xBC1B30
        public void set_NotificationDictionary(){} // RVA: 0xB6A8C0
        public void get_NotificationsToDelete(){} // RVA: 0xBBF8F0
        public void set_NotificationsToDelete(){} // RVA: 0xBBF900
        public void get_NotificationsToUpdate(){} // RVA: 0xBE58B0
        public void set_NotificationsToUpdate(){} // RVA: 0xCA4DF0
        public void ContainsValidImageDataAttachment(){} // RVA: 0xA7A6AB0
        public void .ctor(){} // RVA: 0xA7A6AD0
        public void In(){} // RVA: 0xA7A6F00
        public void ProcessNotification(){} // RVA: 0xA7A70D0
        public void Remove(){} // RVA: 0xA7A7660
        public void See(){} // RVA: 0xA7A7BC0
        public void FetchFriendRequests(){} // RVA: 0xA7A7C30
        public void FetchNotifications(){} // RVA: 0xA7A7E00
        public void Send(){} // RVA: 0xA7A7FF0
        public void MarkAsSeen(){} // RVA: 0xA7A8D50
        public void Delete(){} // RVA: 0xA7A9020
        public void Hide(){} // RVA: 0xA7A9470
        public void AnswerNotification(){} // RVA: 0xA7A9770
        public void ReplyNotification(){} // RVA: 0xA7A9AE0
        public void AcceptFriendRequest(){} // RVA: 0xA7A9CB0
        public void .cctor(){} // RVA: 0xA7AA0E0
        public void <get_RecentNotifications>b__25_0(){} // RVA: 0xA7AA170
        public void <FetchNotifications>b__54_0(){} // RVA: 0xA7AA280
    }

    public class QueueEvent : EventArgs
    {
        public object EventType;
        public object InstanceLocation;
        public object Expiry;
        public object Position;
        public object QueueSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7AEF90
    }

    public class QueueWebSocketEventHandler : Object
    {
        public object OnUpdateReceived;

        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0xA7ADB70
        public void remove_OnUpdateReceived(){} // RVA: 0xA7ADC80
        public void In(){} // RVA: 0xA7ADD90
        public void HandleReady(){} // RVA: 0xA7ADF50
        public void Handle(){} // RVA: 0xA7AE0F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Router : Object
    {
        public object _routes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7AEFE0
        public void AddRoute(){} // RVA: 0xA7AF0A0
        public void ProcessItem(){} // RVA: 0xA7AF1F0
    }

    public class SocketEnvelope : Object
    {
        public object _type;
        public object _content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7AF9F0
        public void get_type(){} // RVA: 0xB5DBF0
        public void set_type(){} // RVA: 0xB44D60
        public void get_content(){} // RVA: 0xB465B0
        public void set_content(){} // RVA: 0xBA9BA0
    }

    public class UpdateEvent : EventArgs
    {
        public object _user;
        public object _messageType;

        // ── Methods ──
        public void get_user(){} // RVA: 0xB5DBF0
        public void set_user(){} // RVA: 0xB44D60
        public void get_messageType(){} // RVA: 0xE62D00
        public void set_messageType(){} // RVA: 0x1033F40
        public void .ctor(){} // RVA: 0xA7A2CD0
    }

    public class WebsocketPipeline : Object
    {
        public object OnConnectionEstablished;
        public object OnLostConnection;
        public object _router;
        public object _endpoint;
        public object _authToken;
        public object _macAddress;
        public object _clientVersion;
        public object _platform;
        public object _connectionId;
        public object _pipeCancellationSource;

        // ── Methods ──
        public void add_OnConnectionEstablished(){} // RVA: 0xA7AFB50
        public void remove_OnConnectionEstablished(){} // RVA: 0xA7AFC40
        public void add_OnLostConnection(){} // RVA: 0xA7AFD30
        public void remove_OnLostConnection(){} // RVA: 0xA7AFE40
        public void LogError(){} // RVA: 0xA7AFF50
        public void LogDebug(){} // RVA: 0xA7B0100
        public void .ctor(){} // RVA: 0xA7B02B0
        public void ProcessPipe(){} // RVA: 0xA7B0680
        public void Dispose(){} // RVA: 0xA7B07C0
        public void <ProcessPipe>b__17_0(){} // RVA: 0xA7B0890
        public void <ProcessPipe>b__17_1(){} // RVA: 0xEB0F90
        public void <ProcessPipe>b__17_2(){} // RVA: 0xA7B09B0
        public void <ProcessPipe>b__17_3(){} // RVA: 0xA7B0AC0
    }

}