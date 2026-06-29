// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 79
// Methods: 252

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Matchmaking : Object
    {
        // ── Methods ──
        public void ReportResultsInsecure(){} // RVA: 0x7ADEB35B0
        public void GetStats(){} // RVA: 0x7ADEB3C20
        public void Browse(){} // RVA: 0x7ADEB3E70
        public void Browse2(){} // RVA: 0x7ADEB40C0
        public void Cancel(){} // RVA: 0x7ADEB4550
        public void CreateAndEnqueueRoom(){} // RVA: 0x7ADEB46F0
        public void CreateAndEnqueueRoom2(){} // RVA: 0x7ADEB4970
        public void CreateRoom(){} // RVA: 0x7ADEB4BB0
        public void CreateRoom2(){} // RVA: 0x7ADEB4E00
        public void Enqueue(){} // RVA: 0x7ADEB5040
        public void Enqueue2(){} // RVA: 0x7ADEB5290
        public void EnqueueRoom(){} // RVA: 0x7ADEB54D0
        public void EnqueueRoom2(){} // RVA: 0x7ADEB56B0
        public void GetAdminSnapshot(){} // RVA: 0x7ADEB5880
        public void JoinRoom(){} // RVA: 0x7ADEB5A30
        public void StartMatch(){} // RVA: 0x7ADEB5C00
        public void SetMatchFoundNotificationCallback(){} // RVA: 0x7ADEB5DA0
    }

    public class Media : Object
    {
        // ── Methods ──
        public void ShareToFacebook(){} // RVA: 0x7ADEC4FD0
    }

    public class MessageWithHttpTransferUpdate : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAE6F0
        public void GetHttpTransferUpdate(){} // RVA: 0x7ADEAE740
        public void GetDataFromMessage(){} // RVA: 0x7ADEAE780
    }

    public class MessageWithLeaderboardDidUpdate : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAE1E0
        public void GetLeaderboardDidUpdate(){} // RVA: 0x7ADEAE260
        public void GetDataFromMessage(){} // RVA: 0x7ADEAE2A0
    }

    public class MessageWithMatchmakingBrowseResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAE500
        public void GetMatchmakingEnqueueResult(){} // RVA: 0x7ADEAE550
        public void GetRoomList(){} // RVA: 0x7ADEAE5A0
        public void GetDataFromMessage(){} // RVA: 0x7ADEAE5F0
    }

    public class MessageWithMatchmakingNotification : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAE3D0
        public void GetRoom(){} // RVA: 0x7ADEAE420
        public void GetDataFromMessage(){} // RVA: 0x7ADEAE460
    }

    public class MessageWithNetSyncConnection : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAA230
        public void GetNetSyncConnection(){} // RVA: 0x7ADEAA280
        public void GetDataFromMessage(){} // RVA: 0x7ADEAA2C0
    }

    public class MessageWithNetSyncSessionList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAA3C0
        public void GetNetSyncSessionList(){} // RVA: 0x7ADEAA410
        public void GetDataFromMessage(){} // RVA: 0x7ADEAA450
    }

    public class MessageWithNetSyncSessionsChangedNotification : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAA550
        public void GetNetSyncSessionsChangedNotification(){} // RVA: 0x7ADEAA5A0
        public void GetDataFromMessage(){} // RVA: 0x7ADEAA5E0
    }

    public class MessageWithNetSyncSetSessionPropertyResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAA850
        public void GetNetSyncSetSessionPropertyResult(){} // RVA: 0x7ADEAA8A0
        public void GetDataFromMessage(){} // RVA: 0x7ADEAA8E0
    }

    public class MessageWithNetSyncVoipAttenuationValueList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAAAF0
        public void GetNetSyncVoipAttenuationValueList(){} // RVA: 0x7ADEAAB40
        public void GetDataFromMessage(){} // RVA: 0x7ADEAAB80
    }

    public class MessageWithNetworkingPeer : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEADCB0
        public void GetNetworkingPeer(){} // RVA: 0x7ADEADD00
        public void GetDataFromMessage(){} // RVA: 0x7ADEADD40
    }

    public class MessageWithOrgScopedID : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAAC80
        public void GetOrgScopedID(){} // RVA: 0x7ADEAACD0
        public void GetDataFromMessage(){} // RVA: 0x7ADEAAD10
    }

    public class MessageWithParty : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAAEA0
        public void GetParty(){} // RVA: 0x7ADEAAEF0
        public void GetDataFromMessage(){} // RVA: 0x7ADEAAF30
    }

    public class MessageWithPartyID : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAB100
        public void GetPartyID(){} // RVA: 0x7ADEAB150
        public void GetDataFromMessage(){} // RVA: 0x7ADEAB190
    }

    public class MessageWithPartyUnderCurrentParty : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAAFD0
        public void GetParty(){} // RVA: 0x7ADEAB020
        public void GetDataFromMessage(){} // RVA: 0x7ADEAB060
    }

    public class MessageWithPartyUpdateNotification : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAB320
        public void GetPartyUpdateNotification(){} // RVA: 0x7ADEAB370
        public void GetDataFromMessage(){} // RVA: 0x7ADEAB3B0
    }

    public class MessageWithPidList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAB4B0
        public void GetPidList(){} // RVA: 0x7ADEAB500
        public void GetDataFromMessage(){} // RVA: 0x7ADEAB540
    }

    public class MessageWithPingResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEADEF0
        public void GetPingResult(){} // RVA: 0x7ADEADF40
        public void GetDataFromMessage(){} // RVA: 0x7ADEADF80
    }

    public class MessageWithPlatformInitialize : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAE880
        public void GetPlatformInitialize(){} // RVA: 0x7ADEAE8D0
        public void GetDataFromMessage(){} // RVA: 0x7ADEAE910
    }

    public class MessageWithProductList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAB640
        public void GetProductList(){} // RVA: 0x7ADEAB690
        public void GetDataFromMessage(){} // RVA: 0x7ADEAB6D0
    }

    public class MessageWithPurchase : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAB7D0
        public void GetPurchase(){} // RVA: 0x7ADEAB820
        public void GetDataFromMessage(){} // RVA: 0x7ADEAB860
    }

    public class MessageWithPurchaseList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAB960
        public void GetPurchaseList(){} // RVA: 0x7ADEAB9B0
        public void GetDataFromMessage(){} // RVA: 0x7ADEAB9F0
    }

    public class MessageWithRejoinDialogResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEABAF0
        public void GetRejoinDialogResult(){} // RVA: 0x7ADEABB40
        public void GetDataFromMessage(){} // RVA: 0x7ADEABB80
    }

    public class MessageWithRoom : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEABD20
        public void GetRoom(){} // RVA: 0x7ADEABD70
        public void GetDataFromMessage(){} // RVA: 0x7ADEABDB0
    }

    public class MessageWithRoomInviteNotification : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAC240
        public void GetRoomInviteNotification(){} // RVA: 0x7ADEAC290
        public void GetDataFromMessage(){} // RVA: 0x7ADEAC2D0
    }

    public class MessageWithRoomInviteNotificationList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAC3D0
        public void GetRoomInviteNotificationList(){} // RVA: 0x7ADEAC420
        public void GetDataFromMessage(){} // RVA: 0x7ADEAC460
    }

    public class MessageWithRoomList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAC0B0
        public void GetRoomList(){} // RVA: 0x7ADEAC100
        public void GetDataFromMessage(){} // RVA: 0x7ADEAC140
    }

    public class MessageWithRoomUnderCurrentRoom : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEABE50
        public void GetRoom(){} // RVA: 0x7ADEABEA0
        public void GetDataFromMessage(){} // RVA: 0x7ADEABEE0
    }

    public class MessageWithRoomUnderViewerRoom : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEABF80
        public void GetRoom(){} // RVA: 0x7ADEABFD0
        public void GetDataFromMessage(){} // RVA: 0x7ADEAC010
    }

    public class MessageWithSdkAccountList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAC560
        public void GetSdkAccountList(){} // RVA: 0x7ADEAC5B0
        public void GetDataFromMessage(){} // RVA: 0x7ADEAC5F0
    }

    public class MessageWithSendInvitesResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAC6F0
        public void GetSendInvitesResult(){} // RVA: 0x7ADEAC740
        public void GetDataFromMessage(){} // RVA: 0x7ADEAC780
    }

    public class MessageWithShareMediaResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAC990
        public void GetShareMediaResult(){} // RVA: 0x7ADEAC9E0
        public void GetDataFromMessage(){} // RVA: 0x7ADEACA20
    }

    public class MessageWithString : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEACBB0
        public void GetString(){} // RVA: 0x7ADEACC00
        public void GetDataFromMessage(){} // RVA: 0x7ADEACC40
    }

    public class MessageWithSystemVoipState : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEACC90
        public void GetSystemVoipState(){} // RVA: 0x7ADEACCE0
        public void GetDataFromMessage(){} // RVA: 0x7ADEACD20
    }

    public class MessageWithUser : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEACF10
        public void GetUser(){} // RVA: 0x7ADEACF60
        public void GetDataFromMessage(){} // RVA: 0x7ADEACFA0
    }

    public class MessageWithUserAndRoomList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAD0A0
        public void GetUserAndRoomList(){} // RVA: 0x7ADEAD0F0
        public void GetDataFromMessage(){} // RVA: 0x7ADEAD130
    }

    public class MessageWithUserCapabilityList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAD3C0
        public void GetUserCapabilityList(){} // RVA: 0x7ADEAD410
        public void GetDataFromMessage(){} // RVA: 0x7ADEAD450
    }

    public class MessageWithUserDataStoreUpdateResponse : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAD550
        public void GetUserDataStoreUpdateResponse(){} // RVA: 0x7ADEAD5A0
        public void GetDataFromMessage(){} // RVA: 0x7ADEAD5E0
    }

    public class MessageWithUserList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAD230
        public void GetUserList(){} // RVA: 0x7ADEAD280
        public void GetDataFromMessage(){} // RVA: 0x7ADEAD2C0
    }

    public class MessageWithUserProof : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAD780
        public void GetUserProof(){} // RVA: 0x7ADEAD7D0
        public void GetDataFromMessage(){} // RVA: 0x7ADEAD810
    }

    public class MessageWithUserReportID : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEADA30
        public void GetUserReportID(){} // RVA: 0x7ADEADA80
        public void GetDataFromMessage(){} // RVA: 0x7ADEADAC0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A230
        public void get_Data(){} // RVA: 0x7A84A5BD0
        public void GetDataFromMessage(){} // RVA: 0x7A7E01B10
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class MultiplayerErrorOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAEAA0
        public void SetErrorKey(){} // RVA: 0x7ADEAEB50
        public void op_Explicit(){} // RVA: 0x7ADE6D8D0
        public void Finalize(){} // RVA: 0x7ADEAEC10
        public void Handle(){} // RVA: 0x7B3F3AFF8
    }

}