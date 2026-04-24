// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Transmtn
// Classes: 26
// Methods: 130

namespace ThirdParty.Other.Transmtn
{
    public class Api : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574E4F90
        public void Dispose(){} // RVA: 0x7FFD574E5E90
    }

    public class ChallengesWebsocketEventHandler : Object
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFD574E5F60
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFD574E6060
        public void In(){} // RVA: 0x7FFD574E6160
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ContentEvent : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574E7CC0
    }

    public class ContentWebSocketEventHandler : Object
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFD574E6A00
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFD574E6B00
        public void In(){} // RVA: 0x7FFD574E6C00
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class EconomyEvent : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574E9330
    }

    public class EconomyWebsocketEventHandler : Object
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFD574E7D10
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFD574E7E10
        public void In(){} // RVA: 0x7FFD574E7F10
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class GroupEvent : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574EA850
    }

    public class GroupsWebSocketEventHandler : Object
    {
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
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574EBFE0
    }

    public class InstanceWebSocketEventHandler : Object
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFD574EB290
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFD574EB390
        public void In(){} // RVA: 0x7FFD574EB490
        public void Handle(){} // RVA: 0x7FFD574EB650
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class InventoryEvent : Object
    {
        public object Type;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD4E38E5C0
        public void set_Type(){} // RVA: 0x7FFD4E3440C0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class InventoryWebSocketEventHandler : Object
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFD574EC030
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFD574EC130
        public void In(){} // RVA: 0x7FFD574EC230
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class PhoneBook : Object
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFD574ECF40
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFD574ED040
        public void In(){} // RVA: 0x7FFD574ED140
        public void Handle(){} // RVA: 0x7FFD574ED2F0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class PostOffice : Object
    {
        public object HttpClient;
        public object Messages;
        public object FriendRequests;
        public object Invites;
        public object Broadcasts;
        public object Alerts;
        public object TopFourNotifications;
        public object RecentNotifications;
        public object Notifications;
        public object SortedNotifications;
        public object NotificationDictionary;
        public object NotificationsToDelete;
        public object NotificationsToUpdate;

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
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574F9190
    }

    public class QueueWebSocketEventHandler : Object
    {
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
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574FA320
        public void AddRoute(){} // RVA: 0x7FFD574FA3E0
        public void ProcessItem(){} // RVA: 0x7FFD574FA520
    }

    public class SocketEnvelope : Object
    {
        public object type;
        public object content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574FAD20
        public void get_type(){} // RVA: 0x7FFD4E35C380
        public void set_type(){} // RVA: 0x7FFD4E342E30
        public void get_content(){} // RVA: 0x7FFD4E3447C0
        public void set_content(){} // RVA: 0x7FFD4E3A7E80
    }

    public class TextureEvent : Object
    {
        public object Type;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD4E38E5C0
        public void set_Type(){} // RVA: 0x7FFD4E3440C0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TextureWebSocketEventHandler : Object
    {
        // ── Methods ──
        public void add_OnUpdateReceived(){} // RVA: 0x7FFD574F91E0
        public void remove_OnUpdateReceived(){} // RVA: 0x7FFD574F92E0
        public void In(){} // RVA: 0x7FFD574F93E0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class UpdateEvent : EventArgs
    {
        public object user;
        public object messageType;

        // ── Methods ──
        public void get_user(){} // RVA: 0x7FFD4E35C380
        public void set_user(){} // RVA: 0x7FFD4E342E30
        public void get_messageType(){} // RVA: 0x7FFD4E577800
        public void set_messageType(){} // RVA: 0x7FFD4ED4CD10
        public void .ctor(){} // RVA: 0x7FFD574ECE80
    }

    public class WebsocketPipeline : Object
    {
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