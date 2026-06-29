// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 8
// Methods: 12

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class NetSyncConnection : Object
    {
        public object ConnectionId;
        public object DisconnectReason;
        public object SessionId;
        public object Status;
        public object ZoneId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B60A30
    }

    public class NetSyncSession : Object
    {
        public object ConnectionId;
        public object Muted;
        public object SessionId;
        public object UserId;
        public object VoipGroup;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B60D00
    }

    public class NetSyncSessionList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B60FD0
    }

    public class NetSyncSessionsChangedNotification : Object
    {
        public object ConnectionId;
        public object Sessions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B612A0
    }

    public class NetSyncSetSessionPropertyResult : Object
    {
        public object Session;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B61450
    }

    public class NetSyncVoipAttenuationValue : Object
    {
        public object Decibels;
        public object Distance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B615A0
    }

    public class NetSyncVoipAttenuationValueList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B616D0
    }

    public class NetworkingPeer : Object
    {
        public object _iD;
        public object _state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2232610
        public void get_ID(){} // RVA: 0xB5DBF0
        public void set_ID(){} // RVA: 0x2230E30
        public void get_State(){} // RVA: 0xE62D00
        public void set_State(){} // RVA: 0x1033F40
    }

}