// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 4
// Methods: 25

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Net : Object
    {
        // ── Methods ──
        public void ReadPacket(){} // RVA: 0x7ADEB63C0
        public void SendPacket(){} // RVA: 0x7ADEB6640
        public void Connect(){} // RVA: 0x7ADEB67C0
        public void Accept(){} // RVA: 0x7ADEB68F0
        public void Close(){} // RVA: 0x7ADEB6A20
        public void IsConnected(){} // RVA: 0x7ADEB6B50
        public void SendPacketToCurrentRoom(){} // RVA: 0x7ADEB6C80
        public void AcceptForCurrentRoom(){} // RVA: 0x7ADEB6DE0
        public void CloseForCurrentRoom(){} // RVA: 0x7ADEB6F00
        public void Ping(){} // RVA: 0x7ADEB7020
        public void SetConnectionStateChangedCallback(){} // RVA: 0x7ADEB71E0
        public void SetPeerConnectRequestCallback(){} // RVA: 0x7ADEB7250
        public void SetPingResultNotificationCallback(){} // RVA: 0x7ADEB72C0
    }

    public class NetSync : Object
    {
        // ── Methods ──
        public void SetConnectionStatusChangedNotificationCallback(){} // RVA: 0x7ADEC5240
        public void SetSessionsChangedNotificationCallback(){} // RVA: 0x7ADEC52B0
    }

    public class NetSyncOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAED00
        public void SetVoipGroup(){} // RVA: 0x7ADEAEDB0
        public void SetVoipStreamDefault(){} // RVA: 0x7ADEAEEF0
        public void SetZoneId(){} // RVA: 0x7ADEAEFB0
        public void op_Explicit(){} // RVA: 0x7ADE6D8D0
        public void Finalize(){} // RVA: 0x7ADEAF0F0
        public void Handle(){} // RVA: 0x7B3FB4428
    }

    public class Notifications : Object
    {
        // ── Methods ──
        public void GetRoomInviteNotifications(){} // RVA: 0x7ADEC5320
        public void MarkAsRead(){} // RVA: 0x7ADEC54D0
        public void GetNextRoomInviteNotificationListPage(){} // RVA: 0x7ADEC5670
    }

}