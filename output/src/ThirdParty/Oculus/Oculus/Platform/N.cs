// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 4
// Methods: 24

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Net : Object
    {
        // ── Methods ──
        public void ReadPacket(){} // RVA: 0x7FFAC8861800
        public void SendPacket(){} // RVA: 0x7FFAC8861A80
        public void Connect(){} // RVA: 0x7FFAC8861C00
        public void Accept(){} // RVA: 0x7FFAC8861D30
        public void Close(){} // RVA: 0x7FFAC8861E60
        public void IsConnected(){} // RVA: 0x7FFAC8861F90
        public void SendPacketToCurrentRoom(){} // RVA: 0x7FFAC88620C0
        public void AcceptForCurrentRoom(){} // RVA: 0x7FFAC8862220
        public void CloseForCurrentRoom(){} // RVA: 0x7FFAC8862340
        public void Ping(){} // RVA: 0x7FFAC8862460
        public void SetConnectionStateChangedCallback(){} // RVA: 0x7FFAC8862620
        public void SetPeerConnectRequestCallback(){} // RVA: 0x7FFAC8862690
        public void SetPingResultNotificationCallback(){} // RVA: 0x7FFAC8862700
    }

    public class NetSync : Object
    {
        // ── Methods ──
        public void SetConnectionStatusChangedNotificationCallback(){} // RVA: 0x7FFAC8870630
        public void SetSessionsChangedNotificationCallback(){} // RVA: 0x7FFAC88706A0
    }

    public class NetSyncOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC885A120
        public void SetVoipGroup(){} // RVA: 0x7FFAC885A1D0
        public void SetVoipStreamDefault(){} // RVA: 0x7FFAC885A310
        public void SetZoneId(){} // RVA: 0x7FFAC885A3D0
        public void op_Explicit(){} // RVA: 0x7FFAC8818EF0
        public void Finalize(){} // RVA: 0x7FFAC885A510
    }

    public class Notifications : Object
    {
        // ── Methods ──
        public void GetRoomInviteNotifications(){} // RVA: 0x7FFAC8870710
        public void MarkAsRead(){} // RVA: 0x7FFAC88708C0
        public void GetNextRoomInviteNotificationListPage(){} // RVA: 0x7FFAC8870A60
    }

}