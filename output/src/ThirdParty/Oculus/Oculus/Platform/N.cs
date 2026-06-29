// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 4
// Methods: 24

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Net : Object
    {
        // ── Methods ──
        public void ReadPacket(){} // RVA: 0x6B3D580
        public void SendPacket(){} // RVA: 0x6B3D800
        public void Connect(){} // RVA: 0x6B3D980
        public void Accept(){} // RVA: 0x6B3DAB0
        public void Close(){} // RVA: 0x6B3DBE0
        public void IsConnected(){} // RVA: 0x6B3DD10
        public void SendPacketToCurrentRoom(){} // RVA: 0x6B3DE40
        public void AcceptForCurrentRoom(){} // RVA: 0x6B3DFA0
        public void CloseForCurrentRoom(){} // RVA: 0x6B3E0C0
        public void Ping(){} // RVA: 0x6B3E1E0
        public void SetConnectionStateChangedCallback(){} // RVA: 0x6B3E3A0
        public void SetPeerConnectRequestCallback(){} // RVA: 0x6B3E410
        public void SetPingResultNotificationCallback(){} // RVA: 0x6B3E480
    }

    public class NetSync : Object
    {
        // ── Methods ──
        public void SetConnectionStatusChangedNotificationCallback(){} // RVA: 0x6B4C400
        public void SetSessionsChangedNotificationCallback(){} // RVA: 0x6B4C470
    }

    public class NetSyncOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B35EC0
        public void SetVoipGroup(){} // RVA: 0x6B35F70
        public void SetVoipStreamDefault(){} // RVA: 0x6B360B0
        public void SetZoneId(){} // RVA: 0x6B36170
        public void op_Explicit(){} // RVA: 0x6AF4C10
        public void Finalize(){} // RVA: 0x6B362B0
    }

    public class Notifications : Object
    {
        // ── Methods ──
        public void GetRoomInviteNotifications(){} // RVA: 0x6B4C4E0
        public void MarkAsRead(){} // RVA: 0x6B4C690
        public void GetNextRoomInviteNotificationListPage(){} // RVA: 0x6B4C830
    }

}