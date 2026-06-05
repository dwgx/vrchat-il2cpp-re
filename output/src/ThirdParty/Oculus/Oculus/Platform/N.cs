// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 4
// Methods: 24

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Net
    {
        // ── Methods ──
        public void ReadPacket(){} // RVA: 0x7FFAF8B7A120
        public void SendPacket(){} // RVA: 0x7FFAF8B7A3A0
        public void Connect(){} // RVA: 0x7FFAF8B7A520
        public void Accept(){} // RVA: 0x7FFAF8B7A650
        public void Close(){} // RVA: 0x7FFAF8B7A780
        public void IsConnected(){} // RVA: 0x7FFAF8B7A8B0
        public void SendPacketToCurrentRoom(){} // RVA: 0x7FFAF8B7A9E0
        public void AcceptForCurrentRoom(){} // RVA: 0x7FFAF8B7AB40
        public void CloseForCurrentRoom(){} // RVA: 0x7FFAF8B7AC60
        public void Ping(){} // RVA: 0x7FFAF8B7AD80
        public void SetConnectionStateChangedCallback(){} // RVA: 0x7FFAF8B7AF40
        public void SetPeerConnectRequestCallback(){} // RVA: 0x7FFAF8B7AFB0
        public void SetPingResultNotificationCallback(){} // RVA: 0x7FFAF8B7B020
    }

    public class NetSync
    {
        // ── Methods ──
        public void SetConnectionStatusChangedNotificationCallback(){} // RVA: 0x7FFAF8B88F50
        public void SetSessionsChangedNotificationCallback(){} // RVA: 0x7FFAF8B88FC0
    }

    public class NetSyncOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B72A40
        public void SetVoipGroup(){} // RVA: 0x7FFAF8B72AF0
        public void SetVoipStreamDefault(){} // RVA: 0x7FFAF8B72C30
        public void SetZoneId(){} // RVA: 0x7FFAF8B72CF0
        public void op_Explicit(){} // RVA: 0x7FFAF8B31810
        public void Finalize(){} // RVA: 0x7FFAF8B72E30
    }

    public class Notifications
    {
        // ── Methods ──
        public void GetRoomInviteNotifications(){} // RVA: 0x7FFAF8B89030
        public void MarkAsRead(){} // RVA: 0x7FFAF8B891E0
        public void GetNextRoomInviteNotificationListPage(){} // RVA: 0x7FFAF8B89380
    }

}