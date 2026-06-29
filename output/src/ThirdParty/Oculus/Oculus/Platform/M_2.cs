// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 79
// Methods: 251

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Matchmaking : Object
    {
        // ── Methods ──
        public void ReportResultsInsecure(){} // RVA: 0x6B3A770
        public void GetStats(){} // RVA: 0x6B3ADE0
        public void Browse(){} // RVA: 0x6B3B030
        public void Browse2(){} // RVA: 0x6B3B280
        public void Cancel(){} // RVA: 0x6B3B710
        public void CreateAndEnqueueRoom(){} // RVA: 0x6B3B8B0
        public void CreateAndEnqueueRoom2(){} // RVA: 0x6B3BB30
        public void CreateRoom(){} // RVA: 0x6B3BD70
        public void CreateRoom2(){} // RVA: 0x6B3BFC0
        public void Enqueue(){} // RVA: 0x6B3C200
        public void Enqueue2(){} // RVA: 0x6B3C450
        public void EnqueueRoom(){} // RVA: 0x6B3C690
        public void EnqueueRoom2(){} // RVA: 0x6B3C870
        public void GetAdminSnapshot(){} // RVA: 0x6B3CA40
        public void JoinRoom(){} // RVA: 0x6B3CBF0
        public void StartMatch(){} // RVA: 0x6B3CDC0
        public void SetMatchFoundNotificationCallback(){} // RVA: 0x6B3CF60
    }

    public class Media : Object
    {
        // ── Methods ──
        public void ShareToFacebook(){} // RVA: 0x6B4C190
    }

    public class MessageWithHttpTransferUpdate : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B358B0
        public void GetHttpTransferUpdate(){} // RVA: 0x6B35900
        public void GetDataFromMessage(){} // RVA: 0x6B35940
    }

    public class MessageWithLeaderboardDidUpdate : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B353A0
        public void GetLeaderboardDidUpdate(){} // RVA: 0x6B35420
        public void GetDataFromMessage(){} // RVA: 0x6B35460
    }

    public class MessageWithMatchmakingBrowseResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B356C0
        public void GetMatchmakingEnqueueResult(){} // RVA: 0x6B35710
        public void GetRoomList(){} // RVA: 0x6B35760
        public void GetDataFromMessage(){} // RVA: 0x6B357B0
    }

    public class MessageWithMatchmakingNotification : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B35590
        public void GetRoom(){} // RVA: 0x6B355E0
        public void GetDataFromMessage(){} // RVA: 0x6B35620
    }

    public class MessageWithNetSyncConnection : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B313F0
        public void GetNetSyncConnection(){} // RVA: 0x6B31440
        public void GetDataFromMessage(){} // RVA: 0x6B31480
    }

    public class MessageWithNetSyncSessionList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B31580
        public void GetNetSyncSessionList(){} // RVA: 0x6B315D0
        public void GetDataFromMessage(){} // RVA: 0x6B31610
    }

    public class MessageWithNetSyncSessionsChangedNotification : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B31710
        public void GetNetSyncSessionsChangedNotification(){} // RVA: 0x6B31760
        public void GetDataFromMessage(){} // RVA: 0x6B317A0
    }

    public class MessageWithNetSyncSetSessionPropertyResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B31A10
        public void GetNetSyncSetSessionPropertyResult(){} // RVA: 0x6B31A60
        public void GetDataFromMessage(){} // RVA: 0x6B31AA0
    }

    public class MessageWithNetSyncVoipAttenuationValueList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B31CB0
        public void GetNetSyncVoipAttenuationValueList(){} // RVA: 0x6B31D00
        public void GetDataFromMessage(){} // RVA: 0x6B31D40
    }

    public class MessageWithNetworkingPeer : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B34E70
        public void GetNetworkingPeer(){} // RVA: 0x6B34EC0
        public void GetDataFromMessage(){} // RVA: 0x6B34F00
    }

    public class MessageWithOrgScopedID : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B31E40
        public void GetOrgScopedID(){} // RVA: 0x6B31E90
        public void GetDataFromMessage(){} // RVA: 0x6B31ED0
    }

    public class MessageWithParty : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B32060
        public void GetParty(){} // RVA: 0x6B320B0
        public void GetDataFromMessage(){} // RVA: 0x6B320F0
    }

    public class MessageWithPartyID : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B322C0
        public void GetPartyID(){} // RVA: 0x6B32310
        public void GetDataFromMessage(){} // RVA: 0x6B32350
    }

    public class MessageWithPartyUnderCurrentParty : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B32190
        public void GetParty(){} // RVA: 0x6B321E0
        public void GetDataFromMessage(){} // RVA: 0x6B32220
    }

    public class MessageWithPartyUpdateNotification : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B324E0
        public void GetPartyUpdateNotification(){} // RVA: 0x6B32530
        public void GetDataFromMessage(){} // RVA: 0x6B32570
    }

    public class MessageWithPidList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B32670
        public void GetPidList(){} // RVA: 0x6B326C0
        public void GetDataFromMessage(){} // RVA: 0x6B32700
    }

    public class MessageWithPingResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B350B0
        public void GetPingResult(){} // RVA: 0x6B35100
        public void GetDataFromMessage(){} // RVA: 0x6B35140
    }

    public class MessageWithPlatformInitialize : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B35A40
        public void GetPlatformInitialize(){} // RVA: 0x6B35A90
        public void GetDataFromMessage(){} // RVA: 0x6B35AD0
    }

    public class MessageWithProductList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B32800
        public void GetProductList(){} // RVA: 0x6B32850
        public void GetDataFromMessage(){} // RVA: 0x6B32890
    }

    public class MessageWithPurchase : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B32990
        public void GetPurchase(){} // RVA: 0x6B329E0
        public void GetDataFromMessage(){} // RVA: 0x6B32A20
    }

    public class MessageWithPurchaseList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B32B20
        public void GetPurchaseList(){} // RVA: 0x6B32B70
        public void GetDataFromMessage(){} // RVA: 0x6B32BB0
    }

    public class MessageWithRejoinDialogResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B32CB0
        public void GetRejoinDialogResult(){} // RVA: 0x6B32D00
        public void GetDataFromMessage(){} // RVA: 0x6B32D40
    }

    public class MessageWithRoom : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B32EE0
        public void GetRoom(){} // RVA: 0x6B32F30
        public void GetDataFromMessage(){} // RVA: 0x6B32F70
    }

    public class MessageWithRoomInviteNotification : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B33400
        public void GetRoomInviteNotification(){} // RVA: 0x6B33450
        public void GetDataFromMessage(){} // RVA: 0x6B33490
    }

    public class MessageWithRoomInviteNotificationList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B33590
        public void GetRoomInviteNotificationList(){} // RVA: 0x6B335E0
        public void GetDataFromMessage(){} // RVA: 0x6B33620
    }

    public class MessageWithRoomList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B33270
        public void GetRoomList(){} // RVA: 0x6B332C0
        public void GetDataFromMessage(){} // RVA: 0x6B33300
    }

    public class MessageWithRoomUnderCurrentRoom : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B33010
        public void GetRoom(){} // RVA: 0x6B33060
        public void GetDataFromMessage(){} // RVA: 0x6B330A0
    }

    public class MessageWithRoomUnderViewerRoom : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B33140
        public void GetRoom(){} // RVA: 0x6B33190
        public void GetDataFromMessage(){} // RVA: 0x6B331D0
    }

    public class MessageWithSdkAccountList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B33720
        public void GetSdkAccountList(){} // RVA: 0x6B33770
        public void GetDataFromMessage(){} // RVA: 0x6B337B0
    }

    public class MessageWithSendInvitesResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B338B0
        public void GetSendInvitesResult(){} // RVA: 0x6B33900
        public void GetDataFromMessage(){} // RVA: 0x6B33940
    }

    public class MessageWithShareMediaResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B33B50
        public void GetShareMediaResult(){} // RVA: 0x6B33BA0
        public void GetDataFromMessage(){} // RVA: 0x6B33BE0
    }

    public class MessageWithString : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B33D70
        public void GetString(){} // RVA: 0x6B33DC0
        public void GetDataFromMessage(){} // RVA: 0x6B33E00
    }

    public class MessageWithSystemVoipState : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B33E50
        public void GetSystemVoipState(){} // RVA: 0x6B33EA0
        public void GetDataFromMessage(){} // RVA: 0x6B33EE0
    }

    public class MessageWithUser : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B340D0
        public void GetUser(){} // RVA: 0x6B34120
        public void GetDataFromMessage(){} // RVA: 0x6B34160
    }

    public class MessageWithUserAndRoomList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B34260
        public void GetUserAndRoomList(){} // RVA: 0x6B342B0
        public void GetDataFromMessage(){} // RVA: 0x6B342F0
    }

    public class MessageWithUserCapabilityList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B34580
        public void GetUserCapabilityList(){} // RVA: 0x6B345D0
        public void GetDataFromMessage(){} // RVA: 0x6B34610
    }

    public class MessageWithUserDataStoreUpdateResponse : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B34710
        public void GetUserDataStoreUpdateResponse(){} // RVA: 0x6B34760
        public void GetDataFromMessage(){} // RVA: 0x6B347A0
    }

    public class MessageWithUserList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B343F0
        public void GetUserList(){} // RVA: 0x6B34440
        public void GetDataFromMessage(){} // RVA: 0x6B34480
    }

    public class MessageWithUserProof : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B34940
        public void GetUserProof(){} // RVA: 0x6B34990
        public void GetDataFromMessage(){} // RVA: 0x6B349D0
    }

    public class MessageWithUserReportID : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B34BF0
        public void GetUserReportID(){} // RVA: 0x6B34C40
        public void GetDataFromMessage(){} // RVA: 0x6B34C80
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEAD0
        public void get_Data(){} // RVA: 0xF73960
        public void GetDataFromMessage(){} // RVA: 0x87D490
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class Message`1 : Message
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x46BEB30
        public void get_Data(){} // RVA: 0xB70160
        public void GetDataFromMessage(){} // RVA: 0x881D60
    }

    public class MultiplayerErrorOptions : Object
    {
        public object Handle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B35C60
        public void SetErrorKey(){} // RVA: 0x6B35D10
        public void op_Explicit(){} // RVA: 0x6AF4C10
        public void Finalize(){} // RVA: 0x6B35DD0
    }

}