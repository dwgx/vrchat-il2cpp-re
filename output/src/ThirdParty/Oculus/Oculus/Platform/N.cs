// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 4
// Methods: 24

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Net
    {
        // ── Methods ──
        public void ReadPacket(){} // RVA: 0x60CA120
        public void SendPacket(){} // RVA: 0x60CA3A0
        public void Connect(){} // RVA: 0x60CA520
        public void Accept(){} // RVA: 0x60CA650
        public void Close(){} // RVA: 0x60CA780
        public void IsConnected(){} // RVA: 0x60CA8B0
        public void SendPacketToCurrentRoom(){} // RVA: 0x60CA9E0
        public void AcceptForCurrentRoom(){} // RVA: 0x60CAB40
        public void CloseForCurrentRoom(){} // RVA: 0x60CAC60
        public void Ping(){} // RVA: 0x60CAD80
        public void SetConnectionStateChangedCallback(){} // RVA: 0x60CAF40
        public void SetPeerConnectRequestCallback(){} // RVA: 0x60CAFB0
        public void SetPingResultNotificationCallback(){} // RVA: 0x60CB020
    }

    public class NetSync
    {
        // ── Methods ──
        public void SetConnectionStatusChangedNotificationCallback(){} // RVA: 0x60D8F50
        public void SetSessionsChangedNotificationCallback(){} // RVA: 0x60D8FC0
    }

    public class NetSyncOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C2A40
        public void SetVoipGroup(){} // RVA: 0x60C2AF0
        public void SetVoipStreamDefault(){} // RVA: 0x60C2C30
        public void SetZoneId(){} // RVA: 0x60C2CF0
        public void op_Explicit(){} // RVA: 0x6081810
        public void Finalize(){} // RVA: 0x60C2E30
    }

    public class Notifications
    {
        // ── Methods ──
        public void GetRoomInviteNotifications(){} // RVA: 0x60D9030
        public void MarkAsRead(){} // RVA: 0x60D91E0
        public void GetNextRoomInviteNotificationListPage(){} // RVA: 0x60D9380
    }

}