// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 8
// Methods: 12

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class NetSyncConnection : Object
    {
        public long ConnectionId; // 0x10
        public 0x6B257680 DisconnectReason; // 0x18
        public ulong SessionId; // 0x20
        public 0x6B257628 Status; // 0x28
        public string ZoneId; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8884EA0
    }

    public class NetSyncSession : Object
    {
        public long ConnectionId; // 0x10
        public bool Muted; // 0x18
        public ulong SessionId; // 0x20
        public ulong UserId; // 0x28
        public string VoipGroup; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8885170
    }

    public class NetSyncSessionList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8885440
    }

    public class NetSyncSessionsChangedNotification : Object
    {
        public long ConnectionId; // 0x10
        public Oculus.Platform.Models.NetSyncSessionList Sessions; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8885720
    }

    public class NetSyncSetSessionPropertyResult : Object
    {
        public Oculus.Platform.Models.NetSyncSession Session; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88858D0
    }

    public class NetSyncVoipAttenuationValue : Object
    {
        public float Decibels; // 0x10
        public float Distance; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8885A20
    }

    public class NetSyncVoipAttenuationValueList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8885B50
    }

    public class NetworkingPeer : Object
    {
        public ulong ID; // 0x10
        public 0x6B2578E8 State; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4420710
        public void get_ID(){} // RVA: 0x7FFAC2F3C380
        public void set_ID(){} // RVA: 0x7FFAC441EFB0
        public void get_State(){} // RVA: 0x7FFAC3157800
        public void set_State(){} // RVA: 0x7FFAC392CD10
    }

}