// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 4
// Methods: 24

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Net : Object
    {
        // ── Methods ──
        public void ReadPacket(){} // RVA: 0x7FFE86C0AEF0
        public void SendPacket(){} // RVA: 0x7FFE86C0B170
        public void Connect(){} // RVA: 0x7FFE86C0B2F0
        public void Accept(){} // RVA: 0x7FFE86C0B420
        public void Close(){} // RVA: 0x7FFE86C0B550
        public void IsConnected(){} // RVA: 0x7FFE86C0B680
        public void SendPacketToCurrentRoom(){} // RVA: 0x7FFE86C0B7B0
        public void AcceptForCurrentRoom(){} // RVA: 0x7FFE86C0B910
        public void CloseForCurrentRoom(){} // RVA: 0x7FFE86C0BA30
        public void Ping(){} // RVA: 0x7FFE86C0BB50
        public void SetConnectionStateChangedCallback(){} // RVA: 0x7FFE86C0BD10
        public void SetPeerConnectRequestCallback(){} // RVA: 0x7FFE86C0BD80
        public void SetPingResultNotificationCallback(){} // RVA: 0x7FFE86C0BDF0
    }

    public class NetSync : Object
    {
        // ── Methods ──
        public void SetConnectionStatusChangedNotificationCallback(){} // RVA: 0x7FFE86C19D20
        public void SetSessionsChangedNotificationCallback(){} // RVA: 0x7FFE86C19D90
    }

    public class NetSyncOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C03810
        public void SetVoipGroup(){} // RVA: 0x7FFE86C038C0
        public void SetVoipStreamDefault(){} // RVA: 0x7FFE86C03A00
        public void SetZoneId(){} // RVA: 0x7FFE86C03AC0
        public void op_Explicit(){} // RVA: 0x7FFE86BC25E0
        public void Finalize(){} // RVA: 0x7FFE86C03C00
    }

    public class Notifications : Object
    {
        // ── Methods ──
        public void GetRoomInviteNotifications(){} // RVA: 0x7FFE86C19E00
        public void MarkAsRead(){} // RVA: 0x7FFE86C19FB0
        public void GetNextRoomInviteNotificationListPage(){} // RVA: 0x7FFE86C1A150
    }

}