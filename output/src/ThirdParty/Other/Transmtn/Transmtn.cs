// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Transmtn
// Classes: 33
// Methods: 153

namespace ThirdParty.Other.Transmtn
{
    public class Api : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A52AF60
        public void Dispose(){} // RVA: 0x7FFE8A52BE60
    }

    public class ChallengesWebsocketEventHandler : Object
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFE8A52BF30
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFE8A52C030
        public void In(){} // RVA: 0x7FFE8A52C130
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ContentEvent : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A52DC90
    }

    public class ContentWebSocketEventHandler : Object
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFE8A52C9D0
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFE8A52CAD0
        public void In(){} // RVA: 0x7FFE8A52CBD0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EconomyEvent : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A52F300
    }

    public class EconomyWebsocketEventHandler : Object
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFE8A52DCE0
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFE8A52DDE0
        public void In(){} // RVA: 0x7FFE8A52DEE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class GroupEvent : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A530820
    }

    public class GroupsWebSocketEventHandler : Object
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFE8A52F350
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFE8A52F450
        public void In(){} // RVA: 0x7FFE8A52F550
        public void Handle(){} // RVA: 0x7FFE8A52F700
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class HttpClient : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFE8A530870
        public void Post(){} // RVA: 0x7FFE8A530910
        public void Put(){} // RVA: 0x7FFE8A530BA0
        public void Delete(){} // RVA: 0x7FFE8A530C30
        public void MakeResponseContainer(){} // RVA: 0x7FFE8A530CC0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IAcceptMessages
    {
        // ── Methods ──
        public void In(){}
    }

    public class IEventHandler`1
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFE80E460A0
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFE80E460A0
    }

    public class IServerTimeProvider
    {
        // ── Methods ──
        public void get_ServerTimeUtc(){} // RVA: 0x7FFE80E2E2E0
    }

    public class InstanceEvent : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A531FB0
    }

    public class InstanceWebSocketEventHandler : Object
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFE8A531260
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFE8A531360
        public void In(){} // RVA: 0x7FFE8A531460
        public void Handle(){} // RVA: 0x7FFE8A531620
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class InventoryContentEvent : ContentEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A52DC90
    }

    public class InventoryEvent : Object
    {
        public 0x666A6C8C _type; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE811485C0
        public void set_Type(){} // RVA: 0x7FFE810FE0C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class InventoryShareEvent : InventoryEvent
    {
        public string _fromUserId; // 0x18
        public string _itemId; // 0x20
        public string _fromDisplayName; // 0x28
        public string _token; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE817EE4A0
        public void get_FromUserId(){} // RVA: 0x7FFE810FE7C0
        public void set_FromUserId(){} // RVA: 0x7FFE81161E80
        public void get_ItemId(){} // RVA: 0x7FFE811290C0
        public void set_ItemId(){} // RVA: 0x7FFE811290D0
        public void get_FromDisplayName(){} // RVA: 0x7FFE81129130
        public void set_FromDisplayName(){} // RVA: 0x7FFE810FCE90
        public void get_Token(){} // RVA: 0x7FFE8144E200
        public void set_Token(){} // RVA: 0x7FFE81129890
    }

    public class InventoryWebSocketEventHandler : Object
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFE8A532000
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFE8A532100
        public void In(){} // RVA: 0x7FFE8A532200
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class LegacyContentEvent : ContentEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A52DC90
    }

    public class ModifiedImageUpdateEvent : TextureEvent
    {
        public string _fileID; // 0x18
        public string _versionNumber; // 0x20
        public int _pixelSize; // 0x28
        public bool _needsProcessing; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE817EE4A0
        public void get_FileID(){} // RVA: 0x7FFE810FE7C0
        public void set_FileID(){} // RVA: 0x7FFE81161E80
        public void get_VersionNumber(){} // RVA: 0x7FFE811290C0
        public void set_VersionNumber(){} // RVA: 0x7FFE811290D0
        public void get_PixelSize(){} // RVA: 0x7FFE81549710
        public void set_PixelSize(){} // RVA: 0x7FFE817E4800
        public void get_NeedsProcessing(){} // RVA: 0x7FFE811DA230
        public void set_NeedsProcessing(){} // RVA: 0x7FFE811DA240
    }

    public class NotificationDeleteEvent : ValueType
    {
    }

    public class NotificationEvent : EventArgs
    {
        public Transmtn.DTO.Notifications.Notification _notification; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A5360A0
        public void get_notification(){} // RVA: 0x7FFE81116380
        public void set_notification(){} // RVA: 0x7FFE810FCE30
    }

    public class NotificationUpdateEvent : ValueType
    {
    }

    public class PhoneBook : Object
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFE8A532F10
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFE8A533010
        public void In(){} // RVA: 0x7FFE8A533110
        public void Handle(){} // RVA: 0x7FFE8A5332C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PostOffice : Object
    {
        public Transmtn.HttpClient _httpClient; // 0x10
        public string NOTIFICATION; // 0x18
        public string NOTIFICATIONV2; // 0x20
        public System.EventHandler`1<Transmtn.NotificationEvent> OnNotification; // 0x28
        public int maximumAllowedFileAttachmentInBytes;
        public Transmtn.IServerTimeProvider _serverTimeProvider; // 0x30
        public System.TimeSpan fiveMinutes;
        public System.Collections.Generic.SortedList`2<System.DateTime,Transmtn.DTO.Notifications.Notification> _sortedNotifications; // 0x38
        public System.Collections.Generic.Dictionary`2<string,Transmtn.DTO.Notifications.Notification> _notificationDictionary; // 0x40
        public System.Collections.Generic.List`1<string> _notificationsToDelete; // 0x48
        public System.Collections.Generic.List`1<string> _notificationsToUpdate; // 0x50
        public int fetchCount;
        public object field_12; // 0x8

        // ── Methods ──
        public void get_HttpClient(){} // RVA: 0x7FFE81116380
        public void set_HttpClient(){} // RVA: 0x7FFE810FCE30
        public void add_OnNotification(){} // RVA: 0x7FFE8A536140
        public void remove_OnNotification(){} // RVA: 0x7FFE8A536240
        public void get_Messages(){} // RVA: 0x7FFE8A536340
        public void get_FriendRequests(){} // RVA: 0x7FFE8A5364C0
        public void get_Invites(){} // RVA: 0x7FFE8A536640
        public void get_Broadcasts(){} // RVA: 0x7FFE8A5367C0
        public void get_Alerts(){} // RVA: 0x7FFE8A536940
        public void get_TopFourNotifications(){} // RVA: 0x7FFE8A536AC0
        public void get_RecentNotifications(){} // RVA: 0x7FFE8A536B10
        public void get_Notifications(){} // RVA: 0x7FFE8A536BC0
        public void get_SortedNotifications(){} // RVA: 0x7FFE8143BA80
        public void set_SortedNotifications(){} // RVA: 0x7FFE81437330
        public void get_NotificationDictionary(){} // RVA: 0x7FFE81178740
        public void set_NotificationDictionary(){} // RVA: 0x7FFE81123200
        public void get_NotificationsToDelete(){} // RVA: 0x7FFE81176730
        public void set_NotificationsToDelete(){} // RVA: 0x7FFE81176740
        public void get_NotificationsToUpdate(){} // RVA: 0x7FFE8119C0E0
        public void set_NotificationsToUpdate(){} // RVA: 0x7FFE812534D0
        public void ContainsValidImageDataAttachment(){} // RVA: 0x7FFE8A536C40
        public void .ctor(){} // RVA: 0x7FFE8A536C60
        public void In(){} // RVA: 0x7FFE8A537090
        public void ProcessNotification(){} // RVA: 0x7FFE8A537260
        public void Remove(){} // RVA: 0x7FFE8A5377F0 | overloaded x2
        public void See(){} // RVA: 0x7FFE8A537D40 | overloaded x2
        public void FetchFriendRequests(){} // RVA: 0x7FFE8A537DB0
        public void FetchNotifications(){} // RVA: 0x7FFE8A537F90
        public void Send(){} // RVA: 0x7FFE8A538190
        public void MarkAsSeen(){} // RVA: 0x7FFE8A538EF0
        public void Delete(){} // RVA: 0x7FFE8A5391C0
        public void Hide(){} // RVA: 0x7FFE8A539610
        public void AnswerNotification(){} // RVA: 0x7FFE8A539910
        public void ReplyNotification(){} // RVA: 0x7FFE8A539C90
        public void AcceptFriendRequest(){} // RVA: 0x7FFE8A539E50
        public void .cctor(){} // RVA: 0x7FFE8A53A280
        public void <get_RecentNotifications>b__25_0(){} // RVA: 0x7FFE8A53A310
        public void <FetchNotifications>b__54_0(){} // RVA: 0x7FFE8A53A420
    }

    public class QueueEvent : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A53F160
    }

    public class QueueWebSocketEventHandler : Object
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFE8A53DD40
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFE8A53DE40
        public void In(){} // RVA: 0x7FFE8A53DF40
        public void HandleReady(){} // RVA: 0x7FFE8A53E100
        public void Handle(){} // RVA: 0x7FFE8A53E290
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Router : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A5402F0
        public void AddRoute(){} // RVA: 0x7FFE8A5403B0
        public void ProcessItem(){} // RVA: 0x7FFE8A5404F0
    }

    public class SocketEnvelope : Object
    {
        public string _type; // 0x10
        public string _content; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A540CF0
        public void get_type(){} // RVA: 0x7FFE81116380
        public void set_type(){} // RVA: 0x7FFE810FCE30
        public void get_content(){} // RVA: 0x7FFE810FE7C0
        public void set_content(){} // RVA: 0x7FFE81161E80
    }

    public class TextureEvent : Object
    {
        public + _type; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE811485C0
        public void set_Type(){} // RVA: 0x7FFE810FE0C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TextureWebSocketEventHandler : Object
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFE8A53F1B0
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFE8A53F2B0
        public void In(){} // RVA: 0x7FFE8A53F3B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UpdateEvent : EventArgs
    {
        public Transmtn.DTO.User _user; // 0x10
        public 0x666A623C _messageType; // 0x18

        // ── Methods ──
        public void get_user(){} // RVA: 0x7FFE81116380
        public void set_user(){} // RVA: 0x7FFE810FCE30
        public void get_messageType(){} // RVA: 0x7FFE813DB630
        public void set_messageType(){} // RVA: 0x7FFE8144DF00
        public void .ctor(){} // RVA: 0x7FFE8A532E50
    }

    public class WebsocketPipeline : Object
    {
        // ── Methods ──
        public void add_OnConnectionEstablished(){} // RVA: 0x7FFE8A540E50
        public void remove_OnConnectionEstablished(){} // RVA: 0x7FFE8A540F40
        public void add_OnLostConnection(){} // RVA: 0x7FFE8A541030
        public void remove_OnLostConnection(){} // RVA: 0x7FFE8A541130
        public void LogError(){} // RVA: 0x7FFE8A541230
        public void LogDebug(){} // RVA: 0x7FFE8A5413E0
        public void .ctor(){} // RVA: 0x7FFE8A541590
        public void ProcessPipe(){} // RVA: 0x7FFE8A541960
        public void Dispose(){} // RVA: 0x7FFE8A541AA0
        public void <ProcessPipe>b__17_0(){} // RVA: 0x7FFE8A541B70
        public void <ProcessPipe>b__17_1(){} // RVA: 0x7FFE8143C6A0
        public void <ProcessPipe>b__17_2(){} // RVA: 0x7FFE8A541C90
        public void <ProcessPipe>b__17_3(){} // RVA: 0x7FFE8A541DA0
    }

}